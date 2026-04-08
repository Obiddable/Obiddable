using Obiddable.Library.Bidding;
using Obiddable.Library.Requesting;
using Obiddable.Library.Requesting.Extensions;

namespace Obiddable.Library.Cataloging;

public static class BiddingExtensions
{
    public static bool CanEditItems(this Bid bid)
        => true;

    public static int GetItemsCount(this Bid bid)
        => bid.Items.Count;

    public static int GetItemCategoriesCount(this Bid bid)
        => bid.Items.GroupBy(x => x.Category).Distinct().Count();

    public static int GetRequestedItemsCount(this Bid bid, IRequestingRepo repo)
        => bid.Items.Distinct().Count(x => x.GetRequestedQuantity(repo) > 0);
}
