using Obiddable.Library.Cataloging;
using Obiddable.Library.Responding;

namespace Obiddable.Library.Electing.Elections;

public class UnmarkedElection : Election
{
    public UnmarkedElection(Item item, int? id = null) : base(item, id)
    {
    }

    public override string ToString()
        => $"Unmarked Election:({Item})";

    public override MarkedElection Elect(ResponseItem electedResponseItem, string reason)
        => new MarkedElection(electedResponseItem, reason, Id);
}
