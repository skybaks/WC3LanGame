using System.Text;
using WC3LanGame.Extensions;
using WC3LanGame.Warcraft3.Types;

namespace WC3LanGame.Warcraft3
{
    internal static class WarcraftPacketProcessor
    {
        // All packets used in Warcraft III have 4 bytes header as below:
        //   1 / uint8  : Magic byte
        //   1 / uint8  : OP Code
        //   2 / uint16 : Packet length including this 4 bytes header

        private const byte FirstHeaderByte = 0xF7; //All LAN UDP or Game TCP packets are using this magic byte in the header
        
        //OP Code's
        private const byte QueryForLanGameOPCode    = 0x2F; // The game sends this packet to query for LAN games
        private const byte GameInfoReplyOPCode      = 0x30; // Sent when received UDP 0x2F packets, this packet contains complete game information as reply
        private const byte GameCancelledOPCode      = 0x33; // This packet is broadcasted to 255.255.255.255 when a game is cancelled
        private const byte GamePlayersChangedOPCode = 0x32; // This packet is broadcasted to 255.255.255.255 when number of in-game players is changed.

        // Length of packets 
        private const ushort GameCancelledPacketLength = 8;
        private const ushort QueryForLanGamePacketLength = 16;
        private const ushort GamePlayersChangedPacketLength = 16;

        public static byte[] GenerateGameCancelledPacket(uint gameId)
        {
            return
            [
                FirstHeaderByte, GameCancelledOPCode,
                .. GameCancelledPacketLength.ToBytes(),
                .. gameId.ToBytes(),
            ];
        }

        public static byte[] GenerateGameAnnouncePacket(GameInfo game)
        {
            uint playersCount = game.CurrentPlayersCount + game.SlotsCount - game.PlayerSlotsCount;

            return
            [
                FirstHeaderByte, GamePlayersChangedOPCode,
                .. GamePlayersChangedPacketLength.ToBytes(),
                .. game.GameId.ToBytes(),
                .. playersCount.ToBytes(),
                .. game.SlotsCount.ToBytes(),
            ];
        }

        public static byte[] GenerateQueryForLanGamesPacket(HostInfo hostInfo)
        {
            IEnumerable<byte> gameTypeBytes = hostInfo.GameType switch
            {
                WarcraftType.TheFrozenThrone => Encoding.UTF8.GetBytes("W3XP").Reverse(),
                WarcraftType.ReignOfChaos    => Encoding.UTF8.GetBytes("WAR3").Reverse(),
                _ => throw new ArgumentOutOfRangeException(nameof(hostInfo))
            };

            return
            [
                FirstHeaderByte, QueryForLanGameOPCode,
                .. QueryForLanGamePacketLength.ToBytes(),
                .. gameTypeBytes,
                .. ((uint)hostInfo.Version.Id()).ToBytes(),
                .. 0U.ToBytes(),
            ];
        }

        public static GameInfo ParseGameInfoPacket(byte[] replyPacket)
        {
            // Check that it is correct Warcraft packet header
            if (replyPacket[0] != FirstHeaderByte || replyPacket[1] != GameInfoReplyOPCode) 
                return null;
            Span<byte> replyPacketSpan = replyPacket.AsSpan();

            WarcraftType gameType = ParseGameType(replyPacket[4..8]);

            uint gameId              = BitConverter.ToUInt32(replyPacketSpan[12..]);
            uint slotsCount          = BitConverter.ToUInt32(replyPacketSpan[^22..]);
            uint currentPlayersCount = BitConverter.ToUInt32(replyPacketSpan[^14..]);
            uint playerSlotsCount    = BitConverter.ToUInt32(replyPacketSpan[^10..]);
            ushort port              = BitConverter.ToUInt16(replyPacketSpan[^2..]);

            string name = GetStringSegment(replyPacketSpan[20..]);

            int encodedSegmentStartIndex = 22 + Encoding.UTF8.GetByteCount(name);
            byte[] decrypted = DecodeStringPart(replyPacketSpan[encodedSegmentStartIndex..]);
            Span<byte> decryptedSpan = decrypted.AsSpan();

            uint settings = BitConverter.ToUInt32(decrypted);

            ushort mapWidth = BitConverter.ToUInt16(decryptedSpan[5..]);
            ushort mapHeight = BitConverter.ToUInt16(decryptedSpan[7..]);

            string mapName = GetStringSegment(decryptedSpan[13..]);
            string lastMapNameSegment = mapName.Split('\\').LastOrDefault();
            mapName = lastMapNameSegment ?? mapName;

            return new GameInfo(gameId, name, port, gameType, slotsCount, currentPlayersCount, playerSlotsCount, 
                mapName, mapWidth, mapHeight);

            static WarcraftType ParseGameType(byte[] gameTypeSegment)
            {
                string gameTypeS = Encoding.UTF8.GetString(gameTypeSegment.Reverse().ToArray());
                return gameTypeS switch
                {
                    "W3XP" => WarcraftType.TheFrozenThrone,
                    "WAR3" => WarcraftType.ReignOfChaos,
                    _ => throw new ArgumentOutOfRangeException(nameof(gameType))
                };
            }
        }

        // Get first null-terminated string from byte array 
        private static string GetStringSegment(ReadOnlySpan<byte> data)
        {
            int firstZeroIndex = data.IndexOf((byte)0);
            if (firstZeroIndex == -1)
                return "";
            return Encoding.UTF8.GetString(data[..firstZeroIndex]);
        }

        // Decode encoded string part. This algorithm is described in 3b part of GamePacketSpecs doc.
        private static byte[] DecodeStringPart(ReadOnlySpan<byte> data)
        {
            byte mask = 0;
            MemoryStream memoryStream = new();

            int firstZeroIndex = data.IndexOf((byte)0);
            var dataCut = data[..firstZeroIndex];

            for (int i = 0; i < dataCut.Length; i++)
            {
                byte b = dataCut[i];

                if (i % 8 != 0)
                {
                    if ((mask & (1 << (i % 8))) == 0)
                        memoryStream.WriteByte((byte)(b - 1));
                    else
                        memoryStream.WriteByte(b);
                }
                else
                    mask = b;
            }

            return memoryStream.ToArray();
        }
    }
}
