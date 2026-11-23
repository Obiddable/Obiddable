using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.Electing;
using Obiddable.Library.Requesting;
using Obiddable.Win.Library;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class ElectionNavigationBoxControl : BidNavigationBoxControl
{
    private readonly IRequestingRepo _requestItemsRepo = new EFRequestingRepo();

    public ElectionNavigationBoxControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Elections");
        EditButtonColor = ApplicationColors.Elections;
    }

    protected override void InitLabels()
    {
        var boxModel = new ElectionBoxModel(_bid, _requestItemsRepo);
        electedItemsValue.Text = boxModel.ElectedItems.ToString();
        unelectedItemsValue.Text = boxModel.UnelectedItems.ToString();
        electedTotalPriceValue.Text = boxModel.ElectedTotalPrice.ToString("C");
        EditEnabled = boxModel.CanEditElections;
    }

    public class ElectionBoxModel
    {
        private readonly IRequestingRepo _requestingRepo = new EFRequestingRepo();

        public ElectionBoxModel(Bid bid, IRequestingRepo repo)
        {
            ElectedItems = bid.GetElectedItemsCount();
            UnelectedItems = bid.GetUnelectedItemsCount(repo);
            ElectedTotalPrice = bid.GetElectedTotalPriceSum(_requestingRepo);
            CanEditElections = bid.CanEditElections();
        }

        public int ElectedItems { get; private set; }
        public int UnelectedItems { get; private set; }
        public decimal ElectedTotalPrice { get; private set; }
        public bool CanEditElections { get; private set; }
    }
}
