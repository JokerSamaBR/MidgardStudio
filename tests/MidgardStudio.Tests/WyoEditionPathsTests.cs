using MidgardStudio.Core;

namespace MidgardStudio.Tests;

public class WyoEditionPathsTests
{
    [Fact]
    public void UsesDGameWhenAvailable()
    {
        var resolved = AppPaths.ResolveHome(null, true, @"C:\Users\usuario\AppData\Local");
        Assert.Equal(@"D:\GAME\MidgardStudio_WYO_Digital", resolved);
    }

    [Fact]
    public void HonorsExplicitAbsoluteOverride()
    {
        var resolved = AppPaths.ResolveHome(@"D:\GAME\Apps\Midgard", false, @"C:\Users\usuario\AppData\Local");
        Assert.Equal(@"D:\GAME\Apps\Midgard", resolved);
    }

    [Fact]
    public void FallsBackToIsolatedLocalAppData()
    {
        var resolved = AppPaths.ResolveHome(null, false, @"C:\Users\usuario\AppData\Local");
        Assert.Equal(@"C:\Users\usuario\AppData\Local\WYO Digital\MidgardStudio", resolved);
    }

    [Fact]
    public void EditionNeverUsesOriginalAppFolderByDefault()
    {
        var resolved = AppPaths.ResolveHome(null, false, @"C:\Users\usuario\AppData\Local");
        Assert.DoesNotContain(@"AppData\Roaming\Midgard Studio", resolved);
    }
}
