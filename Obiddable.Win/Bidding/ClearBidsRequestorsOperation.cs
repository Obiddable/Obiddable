using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.Requesting;

namespace Obiddable.Win.Bidding;

public class ClearBidsRequestorsOperation : BidDataOperation
{
    private readonly IRequestingRepo _requestingRepo = new EFRequestingRepo();
    public ClearBidsRequestorsOperation(Bid bid) : base(bid) { }

    public override bool Confirm()
    {
        return BiddingMessaging.Instance.ConfirmBidClearRequestors(_bid.VendorResponses.Count);
    }

    protected override void RunDataOperation()
	{
		_requestingRepo.DeleteRequestItems_ByBid(_bid.Id);
		_requestingRepo.DeleteRequests_ByBid(_bid.Id);
		_requestingRepo.DeleteRequestors_ByBid(_bid.Id);
		BiddingMessaging.Instance.ShowBidClearRequestorsSuccess();
    }
}
