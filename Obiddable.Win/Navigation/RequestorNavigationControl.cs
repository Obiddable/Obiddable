using Obiddable.Library.Bidding;
using Obiddable.Win.Library;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class RequestorNavigationControl : BidNavigationBoxControl
{

    public RequestorNavigationControl()
    {
        InitializeComponent();
        SetClickEventOnControls(this);
        SetTitle("Requesting");
        EditButtonColor = ApplicationColors.Requesting;
    }

    protected override void InitLabels()
    {
        var boxModel = new RequestorBoxModel(_bid);
        requestsValue.Text = boxModel.Requests.ToString();
        requestorsValue.Text = boxModel.Requestors.ToString();
        estimatedPriceValue.Text = boxModel.EstimatedPrice.ToString("C");
        estimatedPriceWithOverridesValue.Text = boxModel.EstimatedPriceWithOverrides.ToString("C");
        EditEnabled = boxModel.CanEditRequestors;
    }

    public class RequestorBoxModel
    {
        public RequestorBoxModel(Bid bid)
        {
            Requests = bid.GetRequestsCount();
            Requestors = bid.GetRequestorsCount();
            EstimatedPrice = bid.GetRequestorsEstimatedPrice();
            EstimatedPriceWithOverrides = bid.GetRequestorsEstimatedPriceWithOverrides();
            CanEditRequestors = bid.CanEditRequestors();
        }

        public int Requests { get; private set; }
        public int Requestors { get; private set; }
        public decimal EstimatedPrice { get; private set; }
        public decimal EstimatedPriceWithOverrides { get; private set; }
        public bool CanEditRequestors { get; private set; }
    }
}
