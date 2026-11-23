using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;
using Obiddable.Win.Library;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class ItemNavigationBoxControl : BidNavigationBoxControl
{
    public ItemNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Items");
        EditButtonColor = ApplicationColors.Items;
    }

    protected override void InitLabels()
    {
        var boxModel = new ItemBoxModel(_bid);
        itemsCount.Text = boxModel.ItemsCount.ToString();
        categoriesCount.Text = boxModel.CategoriesCount.ToString();
        EditEnabled = boxModel.CanEditItems;
    }

    public class ItemBoxModel
    {
        public ItemBoxModel(Bid _bid)
        {
            ItemsCount = _bid.GetItemsCount();
            CategoriesCount = _bid.GetItemCategoriesCount();
            CanEditItems = _bid.CanEditItems();
        }

        public int ItemsCount { get; private set; }
        public int CategoriesCount { get; private set; }
        public bool CanEditItems { get; private set; }
    }
}
