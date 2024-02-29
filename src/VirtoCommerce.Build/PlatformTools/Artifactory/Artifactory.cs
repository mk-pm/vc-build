using System.Collections.Generic;
using VirtoCommerce.Build.PlatformTools;

namespace PlatformTools.Artifactory;

public class Artifactory : ModuleSource
{
    public override string Name { get; set; } = "Artifactory";
    public string ReleaseUrl { get; set; }
    public string SnapshotUrl { get; set; }
    public List<ArtifactoryModuleItem> Modules { get; set; }
}
