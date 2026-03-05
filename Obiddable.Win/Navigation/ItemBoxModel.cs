using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;

namespace Obiddable.Win.Navigation;

public class ItemBoxModel
{
    public ItemBoxModel(Bid _bid)
    {
        ItemsCount = _bid.GetItemsCount();
        CategoriesCount = _bid.GetItemCategoriesCount();
        CanEditItems = _bid.CanEditItems();
    }

    public int ItemsCount { get; private set; }
    public int CategoriesCount { get; private set; }
    public bool CanEditItems { get; private set; }
}
