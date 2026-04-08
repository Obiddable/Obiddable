using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.Electing;
using Obiddable.Library.Requesting;

namespace Obiddable.Win.Navigation;

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
