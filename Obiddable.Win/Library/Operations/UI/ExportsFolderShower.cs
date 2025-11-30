using Obiddable.Library.Operations;

namespace Obiddable.Win.Library.Operations.UI;

public class ExportsFolderShower : IOperation
{
    private ConfigMenuShower _configMenuShower = new ConfigMenuShower();
    public void Run()
    {
        if (UserConfiguration.Instance.ExportsDirectory.Exists)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = UserConfiguration.Instance.ExportsDirectory.FullName,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
        else
        {
            _configMenuShower.Run();
        }
    }
}
