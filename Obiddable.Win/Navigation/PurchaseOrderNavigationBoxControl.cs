using Obiddable.Library.Bidding;
using Obiddable.Library.Purchasing;
using Obiddable.Win.Library;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class PurchaseOrderNavigationBoxControl : BidNavigationBoxControl
{
    public PurchaseOrderNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Purchasing");
        EditButtonColor = ApplicationColors.Purchasing;
    }

    protected override void InitLabels()
    {
        var boxModel = new PurchaseOrderBoxModel(_bid);
        purchaseOrdersValue.Text = boxModel.PurchaseOrders.ToString();
        purchasedItemsValue.Text = boxModel.PurchasedItems.ToString();
        totalPriceValue.Text = boxModel.TotalPrice.ToString("C");
        EditEnabled = boxModel.CanEditPurchaseOrders;
    }

    public class PurchaseOrderBoxModel
    {
        public PurchaseOrderBoxModel(Bid bid)
        {
            PurchaseOrders = bid.GetPurchaseOrdersCount();
            PurchasedItems = bid.GetPurchaseOrdersItemsCount();
            TotalPrice = bid.GetPurchaseOrdersTotalPriceSum();
            CanEditPurchaseOrders = bid.CanEditPurchaseOrders();
        }

        public int PurchaseOrders { get; private set; }
        public int PurchasedItems { get; private set; }
        public decimal TotalPrice { get; private set; }
        public bool CanEditPurchaseOrders { get; private set; }
    }
}
