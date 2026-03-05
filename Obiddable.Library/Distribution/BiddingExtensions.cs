using Obiddable.Library.Bidding;
using Obiddable.Library.Electing;
using Obiddable.Library.Requesting;

namespace Obiddable.Library.Distribution;

public static class BiddingExtensions
{
    public static bool HasUnmatchedQuantities(this Bid bid, IRequestingRepo requestingRepo, ILegacyElectionsRepo electionsRepo)
    {
        return electionsRepo.GetElectedResponseItemsByBid(bid.Id)
            .Any(responseItem => responseItem.IsMismatchedQuantity(requestingRepo));
    }
}
