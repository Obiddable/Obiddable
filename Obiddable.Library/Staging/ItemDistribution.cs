using Obiddable.Library.Bidding;
using Obiddable.Library.Staging.ItemElections;

namespace Obiddable.Library.Staging;

public class ItemDistribution
{
    public ItemElection ItemElection { get; private set; }
    public Building Building { get; private set; }
    public decimal Quantity { get; private set; }
}
