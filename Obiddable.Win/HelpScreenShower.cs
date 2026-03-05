using Obiddable.Library.Operations;
using Obiddable.Win.Library;
using System.Reflection;

namespace Obiddable.Win;

public class HelpScreenShower : IOperation
{
    private readonly UrlOpener _urlOpener;

    public HelpScreenShower(UrlOpener urlOpener)
    {
        _urlOpener = urlOpener;
    }

    public void Run()
    {
        if (GetHelpUrlFromProject() is string helpUrl)
            _urlOpener.OpenUrl(helpUrl);
    }

    private string? GetHelpUrlFromProject()
    {
        if (
            Assembly
                .GetExecutingAssembly()
                ?.GetCustomAttributes<AssemblyMetadataAttribute>()
                ?.FirstOrDefault(x => x.Key == "HelpUrl")
            is not AssemblyMetadataAttribute helpUrl
        )
        {
            return null;
        }

        return helpUrl.Value;
    }
}
