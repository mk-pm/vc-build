using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Serilog;

namespace PlatformTools.Artifactory;

public class ArtifactoryClient
{
    private readonly HttpClient _client;

    public ArtifactoryClient(string username, string password)
    {
        _client = new HttpClient();
        var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{username}:{password}"));
        _client.DefaultRequestHeaders.Add("Authorization",  $"Basic {base64EncodedAuthenticationString}");
    }

    public async Task<string> DownloadArtifact(string orgPath, string moduleId, string version, string apiUrl, string downloadPath)
    {
        // Retrieve artifact file
        var artifactUrl = $"{apiUrl}/{orgPath}/{moduleId}/{version}.zip";
        Log.Information("Downloading artifact from: {ArtifactUrl}", artifactUrl);
        var fileBytes = await _client.GetByteArrayAsync(artifactUrl);
        var artifactPath = Path.Combine(downloadPath, moduleId);
        await File.WriteAllBytesAsync(artifactPath, fileBytes);

        return artifactPath;
    }
}
