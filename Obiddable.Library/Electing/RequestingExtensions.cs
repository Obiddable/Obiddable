using Obiddable.Library.Requesting;
using Obiddable.Library.Responding;

namespace Obiddable.Library.Electing;

public static class RequestingExtensions
{
    public static decimal ElectedExtendedPrice(this RequestItem requestItem, ILegacyElectionsRepo electionsRepo)
    {
        decimal output;
        ResponseItem electedResponseItem;

        electedResponseItem = electionsRepo.GetElectedResponseItemForItem(requestItem.Item.Id);
        if (electedResponseItem is null)
        {
            throw new RequestItemNotElectedException();
        }
        output = electedResponseItem.Price * requestItem.Quantity;

        return output;
    }

    public static decimal ElectedExtendedPrice(this Request request, ILegacyElectionsRepo electionsRepo)
    {
        decimal output;
        decimal requestItemPrice;

        output = 0;
        foreach (var requestItem in request.RequestItems)
        {
            try
            {
                requestItemPrice = requestItem.ElectedExtendedPrice(electionsRepo);
                output += requestItemPrice;
            }
            catch (RequestItemNotElectedException) { }
        }

        return output;
    }
}
