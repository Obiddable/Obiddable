using Obiddable.Library.Cataloging;
using Obiddable.Library.Distribution;
using Obiddable.Library.EF.Cataloging;
using Obiddable.Library.EF.Electing;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.EF.Responding;
using Obiddable.Library.Electing;
using Obiddable.Library.Requesting;
using Obiddable.Library.Responding;

namespace Obiddable.Win.Electing;

public class ElectItemOperation
{
    private readonly ElectingMessaging _electingMessaging = new ElectingMessaging();
    private readonly ILegacyElectionsRepo _legacyElectionsRepo;
    private readonly ICatalogingRepo _catalogingRepo;
    private readonly IRequestingRepo _requestingRepo;
    private readonly IRespondingRepo _respondingRepo;

    public ElectItemOperation()
        : this(new EFLegacyElectionsRepo(), new EFCatalogingRepo(), new EFRequestingRepo(), new EFRespondingRepo())
    {

    }

    public ElectItemOperation(ILegacyElectionsRepo legacyElectionsRepo, ICatalogingRepo catalogingRepo, IRequestingRepo requestingRepo, IRespondingRepo respondingRepo)
    {
        _legacyElectionsRepo = legacyElectionsRepo;
        _catalogingRepo = catalogingRepo;
        _requestingRepo = requestingRepo;
        _respondingRepo = respondingRepo;
    }

    public void ElectResponseItem(int itemId, int responseItemId, string reason)
    {
        Item item;
        ResponseItem responseItem;

        item = _catalogingRepo.GetItem(itemId);
        responseItem = _respondingRepo.GetResponseItem(responseItemId);
        if (shouldStopBecauseOfMismatchedQuantity(item, responseItem))
        {
            return;
        }
        _legacyElectionsRepo.UpdateResponseItem_Elect(itemId, responseItemId, reason);
    }
    private bool shouldStopBecauseOfMismatchedQuantity(Item item, ResponseItem responseItem)
    {
        if (responseItem.IsMismatchedQuantity(_requestingRepo) == false)
        {
            return false;
        }
        return (_electingMessaging.ConfirmContinueIfMismatched(responseItem, _requestingRepo.GetItemsRequestedQuantity(item), responseItem.AlternateQuantity) == false);
    }
}
