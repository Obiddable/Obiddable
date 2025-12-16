using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Obiddable.Win;

public static class UpdateChecker
{
    private const string REPO_OWNER = "Obiddable";
    private const string REPO_NAME = "Obiddable";

    private static readonly HttpClient client = new HttpClient();

    public static async Task<bool> HasNewReleaseAsync()
    {
        try
        {
            var owner = REPO_OWNER;
            var repo = REPO_NAME;
            var currentVersion = new VersionResolver().GetVersion();
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
            
            string? newRelease = null;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            var url = $"https://api.github.com/repos/{owner}/{repo}/releases";
            client.DefaultRequestHeaders.UserAgent.ParseAdd("release-checker");

            var response = await client.GetAsync(url, cts.Token);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
            using var doc = await JsonDocument.ParseAsync(
                utf8Json: stream, 
                options: default, 
                cancellationToken: cts.Token);

            if (doc.RootElement.GetArrayLength() == 0)
                return false;

            var latest = doc.RootElement[0];
            var tag = latest.GetProperty("tag_name").GetString();
            if (string.IsNullOrWhiteSpace(tag))
                return false;

            var trimmed = tag.StartsWith("v", StringComparison.OrdinalIgnoreCase)
                ? tag.Substring(1)
                : tag;

            if (!Version.TryParse(trimmed, out var latestVersion))
                return false;

            if (!Version.TryParse(currentVersion, out var localVersion))
                return false;

            var hasUpdate = latestVersion > localVersion;
            if (hasUpdate)
                newRelease = tag;

            return hasUpdate;
        }
        catch
        {
            return false;
        }
    }
}
