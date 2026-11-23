using Obiddable.Library.Operations;
using Obiddable.Win.UI;

namespace Obiddable.Win.Configuration;

public class ConfigMenuShower : IOperation
{
    public void Run()
    {
        ConfigForm f = new ConfigForm();
        f.ShowDialog();
    }
}
