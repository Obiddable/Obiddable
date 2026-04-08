using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;
using Obiddable.Library.Staging;
using Obiddable.Library.Staging.ItemElections;

namespace Obiddable.Library.Distribution;

public interface IDistributionRepo
{
    void AddDistributedQuantity(DistributedQuantity distributedQuantity);
    void UpdateDistributedQuantity(DistributedQuantity distributedQuantity);
    void RemoveDistributedQuantity(Building building, Item item);

    BuildingDistribution GetBuildingDistribution(Building building);
    IEnumerable<BuildingDistribution> GetBuildingDistributionsByBidId(Bid bid);
    IEnumerable<ItemElection> GetElectedItemsByBidId(Bid bid);
    int GetRequestedQuantity(Building building, Item item);
    IEnumerable<Building> GetAllBuildingsWhoRequestedItem(Item item);
}
