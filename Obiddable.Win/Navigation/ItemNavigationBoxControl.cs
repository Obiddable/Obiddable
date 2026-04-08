using Obiddable.Win.Library;
using Obiddable.Win.Navigation;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class ItemNavigationBoxControl : BidNavigationBoxControl
{
    public ItemNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Items");
        SetButtonColor(ApplicationColors.Items);
    }

    protected override void InitLabels()
    {
        var boxModel = new ItemBoxModel(_bid);
        itemsCount.Text = boxModel.ItemsCount.ToString();
        categoriesCount.Text = boxModel.CategoriesCount.ToString();
        EditEnabled = boxModel.CanEditItems;
    }
}
