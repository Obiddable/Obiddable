using Obiddable.Library.EF.Requesting;
using Obiddable.Library.Requesting;
using Obiddable.Win.Library;
using Obiddable.Win.Navigation;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class VendorResponseNavigationBoxControl : BidNavigationBoxControl
{
    private readonly IRequestingRepo _requestItemsRepo = new EFRequestingRepo();
    public VendorResponseNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Vendor Responses");
        SetButtonColor(ApplicationColors.VendorResponses);
    }

    protected override void InitLabels()
    {
        var boxModel = new VendorResponseBoxModel(_bid, _requestItemsRepo);
        vendorResponsesValue.Text = boxModel.VendorResponses.ToString();
        itemResponsesValue.Text = boxModel.ItemResponses.ToString();
        noResponseItemsValue.Text = boxModel.NoResponseItems.ToString();
        EditEnabled = boxModel.CanEditVendorResponses;
    }
}
