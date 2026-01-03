using System.Diagnostics;
using Microsoft.Win32;
using WC3LanGame.Warcraft3.Types;

namespace WC3LanGame.Warcraft3;

internal static class WarcraftExecutable
{
    private const string Warcraft3RegistryKey = @"HKEY_CURRENT_USER\Software\Blizzard Entertainment\Warcraft III";
    private const string Warcraft3ProcessName = "war3";

    public static string? KnownWC3Folder { get; set; } = null;

    public static string RunWC3(WarcraftType warcraftType)
    {
        string programKey = warcraftType == WarcraftType.TheFrozenThrone ? "ProgramX" : "Program";

        string program = (string)Registry.GetValue(Warcraft3RegistryKey, programKey, null);

        if (program == null)
        {
            return "Unable to locate Warcraft 3 executable";
        }

        try
        {
            Process.Start(program);
            return "Warcraft3 process started!";
        }
        catch (Exception ex)
        {
            return $"Unable to launch WC3 ({program}).\nException: {ex.Message}";
        }
    }

    public static string GetInstalledWC3Version()
    {
        string program = Registry.GetValue(Warcraft3RegistryKey, "InstallPath", null) + "\\war3.exe";
        if (!File.Exists(program))
            return "";

        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(program);
        return $"{versionInfo.FileMajorPart}.{versionInfo.FileMinorPart}";
    }

    public static string? GetRunningWC3Version()
    {
        string? wc3RuntimeDir = KnownWC3Folder;
        try
        {
            Process? wc3Process = Process.GetProcessesByName(Warcraft3ProcessName).FirstOrDefault();
            wc3RuntimeDir = Path.GetDirectoryName(wc3Process.MainModule.FileName);
        }
        catch (Exception) { }

        if (wc3RuntimeDir is not null)
        {
            KnownWC3Folder = wc3RuntimeDir;
        }
        else
        {
            return null;
        }

        string? gameDllPath = Directory.EnumerateFiles(wc3RuntimeDir, "game.dll", SearchOption.TopDirectoryOnly)
            .Union(Directory.EnumerateFiles(wc3RuntimeDir, "Game.dll", SearchOption.TopDirectoryOnly)).SingleOrDefault();
        if (gameDllPath is null) { return null; }

        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(gameDllPath);
        return $"{versionInfo.FileMajorPart}.{versionInfo.FileMinorPart}";
    }

    public static bool IsWC3ProcessRunning()
    {
        Process[] processes = Process.GetProcessesByName(Warcraft3ProcessName);
        return processes.Length > 0;
    }

    public static string StopWC3ProcessRunning()
    {
        Process? wc3Process = Process.GetProcessesByName(Warcraft3ProcessName).FirstOrDefault();
        if (wc3Process is null)
            return "WC3 isn't running.";

        wc3Process.CloseMainWindow();
        return "WC3 process was stopped.";
    }
}
