namespace PlatformTools.Artifactory;

public class ArtifactoryModuleItem : ModuleItem
{
    public ArtifactoryModuleStage Stage { get; private set; }
    public string OrgPath { get; private set; }

    public ArtifactoryModuleItem(string id, string version, string orgPath, ArtifactoryModuleStage stage) : base(id, version)
    {
        OrgPath = orgPath;
        Stage = stage;
    }

}
