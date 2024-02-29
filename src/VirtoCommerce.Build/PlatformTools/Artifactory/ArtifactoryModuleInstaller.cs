using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Nuke.Common.IO;
using VirtoCommerce.Build.PlatformTools;
using VirtoCommerce.Platform.Core.Modularity;

namespace PlatformTools.Artifactory;

public class ArtifactoryModuleInstaller : ModulesInstallerBase
{
    private readonly ArtifactoryClient _client;
    private readonly string _discoveryPath;
    public ArtifactoryModuleInstaller(string jFrogUsername, string jFrogPassword, string discoveryPath)
    {
        _client = new ArtifactoryClient(jFrogUsername, jFrogPassword);
        _discoveryPath = discoveryPath;
    }

    protected override async Task InnerInstall(ModuleSource source, IProgress<ProgressMessage> progress)
    {
        var artifactory = (Artifactory) source;
        foreach (var module in artifactory.Modules)
        {
            var moduleDestination = Path.Join(_discoveryPath, module.Id);
            Directory.CreateDirectory(moduleDestination);
            FileSystemTasks.EnsureCleanDirectory(moduleDestination);
            progress.ReportInfo($"Downloading {module.Id}");
            var apiUrl = module.Stage == ArtifactoryModuleStage.Snapshot ? artifactory.SnapshotUrl : artifactory.ReleaseUrl;
            var artifactZipPath = await _client.DownloadArtifact(module.OrgPath ,module.Id, module.Version, apiUrl, moduleDestination);
            progress.ReportInfo($"Extracting {module.Id}");
            ZipFile.ExtractToDirectory(artifactZipPath, moduleDestination);
            progress.ReportInfo($"Successfully installed {module.Id}");
        }
    }
}
