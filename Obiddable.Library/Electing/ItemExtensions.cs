using Obiddable.Library.Cataloging;
using Obiddable.Library.Requesting;
using Obiddable.Library.Requesting.Extensions;

namespace Obiddable.Library.Electing;

public static class ItemExtensions
{
    public static string GetFormattedId(this Item item)
        => item.Id.ToString();

    public static string GetFormattedCode(this Item item)
        => item.FormattedCode;

    public static string GetFormattedRequestedQuantity(this Item item, IRequestingRepo repo)
        => item.GetRequestedQuantity(repo).ToString("0.00");
}
