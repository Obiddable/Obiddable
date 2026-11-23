namespace Obiddable.Win.Library;

public class VersionResolver : IVersionResolver
{
    public string GetVersion()
    {
        return typeof(VersionResolver).Assembly.GetName().Version.ToString();
    }
}
