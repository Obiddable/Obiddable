using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.Requesting;
using Obiddable.Library.Responding;
using Obiddable.Win.Library;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class VendorResponseNavigationBoxControl : BidNavigationBoxControl
{
    private readonly IRequestingRepo _requestItemsRepo = new EFRequestingRepo();

    public VendorResponseNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Vendor Responses");
        EditButtonColor = ApplicationColors.VendorResponses;
    }

    protected override void InitLabels()
    {
        var boxModel = new VendorResponseBoxModel(_bid, _requestItemsRepo);
        vendorResponsesValue.Text = boxModel.VendorResponses.ToString();
        itemResponsesValue.Text = boxModel.ItemResponses.ToString();
        noResponseItemsValue.Text = boxModel.NoResponseItems.ToString();
        EditEnabled = boxModel.CanEditVendorResponses;
    }

    class VendorResponseBoxModel
    {
        public VendorResponseBoxModel(Bid bid, IRequestingRepo repo)
        {
            VendorResponses = bid.GetVendorResponsesCount();
            ItemResponses = bid.GetVendorResponsesItemResponsesCount();
            NoResponseItems = bid.GetNoResponseItemsCount(repo);
            CanEditVendorResponses = bid.CanEditVendorResponses();
        }

        public int VendorResponses { get; private set; }
        public int ItemResponses { get; private set; }
        public int NoResponseItems { get; private set; }
        public bool CanEditVendorResponses { get; private set; }
    }
}
