namespace MidgardStudio.Core;

/// <summary>
/// Storage for the WYO Digital edition, isolated from the original program.
/// No implicit migrations of original profiles or backups.
/// </summary>
public static class AppPaths
{
    public const string DefaultGameHome = @"D:\GAME\MidgardStudio_WYO_Digital";

    /// <summary>
    /// Absolute override wins; otherwise use D:\GAME if present, falling back to
    /// a distinct LocalAppData location on PCs without D:\GAME.
    /// </summary>
    public static string ResolveHome(string? overrideHome, bool gameDriveAvailable, string localAppData)
    {
        if (!string.IsNullOrWhiteSpace(overrideHome) && Path.IsPathFullyQualified(overrideHome))
            return Path.GetFullPath(overrideHome);
        if (gameDriveAvailable)
            return DefaultGameHome;
        return Path.Combine(localAppData, "WYO Digital", "MidgardStudio");
    }

    public static string RootDir { get; } = ResolveHome(
        Environment.GetEnvironmentVariable("WYO_MIDGARD_HOME"),
        Directory.Exists(@"D:\GAME"),
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

    public static string RoamingDir { get; } = Path.Combine(RootDir, "config");
    public static string LocalDir { get; } = RootDir;
    public static string BackupsDir { get; } = Path.Combine(RootDir, "backups");

    /// <summary>Legacy snapshots exclusively inside this edition.</summary>
    public static string LegacyRoamingBackupsDir { get; } =
        Path.Combine(RootDir, "legacy-backups");
}
