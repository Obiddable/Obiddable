using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;
using Obiddable.Library.Responding;

namespace Obiddable.Library.Electing.Elections;

public abstract class Election : Entity
{
    public Item Item { get; private set; }

    protected Election(Item item, int? id = null) : base(id)
    {
        Item = item ?? throw new ArgumentNullException(nameof(item));
    }

    public abstract MarkedElection Elect(ResponseItem electedResponseItem, string reason);
}
