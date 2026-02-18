namespace Obiddable.Library.Bidding;

public class BiddingService
{
    private readonly IBiddingRepo _biddingRepo;

    public BiddingService(IBiddingRepo biddingRepo)
    {
        _biddingRepo = biddingRepo;
    }

    public bool BidNameExists(string text, int bidId)
    {
        var bids = _biddingRepo.GetBids();

        if (_biddingRepo.GetBids() is null)
            throw new Exception("Unable to get bids");

        return bids.Any(bid => bid.Id != bidId && bid.Name == text);
    }
}
