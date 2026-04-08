using Obiddable.Library.Cataloging;
using Obiddable.Library.Electing.Elections;

namespace Obiddable.Library.Electing;

public class ElectionsSetFactory
{
    private readonly UnmarkedElectionsFactory _unmarkedElectionsFactory;

    public ElectionsSetFactory(UnmarkedElectionsFactory unmarkedElectionsFactory)
    {
        _unmarkedElectionsFactory = unmarkedElectionsFactory;
    }

    public ElectionSet Build(
        IEnumerable<Item> bidItems,
        IEnumerable<MarkedElection> markedElections
    )
    {
        ElectionSet output;
        IEnumerable<UnmarkedElection> unmarkedElections;

        unmarkedElections = _unmarkedElectionsFactory.BuildUnmarkedElectionsForItems(
            bidItems,
            markedElections
        );
        output = new ElectionSet(markedElections, unmarkedElections);

        return output;
    }
}
