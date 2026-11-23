using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;
using Obiddable.Library.Electing.Elections;

namespace Obiddable.Library.Electing;

public interface IElectingRepo
{
    IEnumerable<MarkedElection> GetMarkedElectionsForBid(Bid bid);

    void UpdateElections(IEnumerable<Election> elections);

    MarkedElection GetMarkedElectionForItem(Item item);
}