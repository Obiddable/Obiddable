using Obiddable.Library.Requesting;
using Obiddable.Library.Requesting.Extensions;
using Obiddable.Library.Responding;

namespace Obiddable.Library.Distribution;

public static class RequestingExtensions
{

    public static bool IsMismatchedQuantity(this ResponseItem responseItem, IRequestingRepo requestingRepo)
    {
        decimal requestedQuantity;
        decimal alternateQuantity;

        if (responseItem.IsAlternate == false)
        {
            return false;
        }
        requestedQuantity = (decimal)responseItem.Item.GetRequestedQuantity(requestingRepo);
        alternateQuantity = responseItem.AlternateQuantity;

        return requestedQuantity != alternateQuantity; ;
    }
}
