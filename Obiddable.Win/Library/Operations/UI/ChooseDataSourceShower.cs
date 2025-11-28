using Obiddable.Library.Operations;
using Obiddable.Win.UI;

namespace Obiddable.Win.Library.Operations.UI;

public class ChooseDataSourceShower : IOperation
{
    public void Run()
    {
        ChooseDataSourceForm f = new ChooseDataSourceForm();
        f.ShowDialog();
	}
}
