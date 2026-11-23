using Obiddable.Library.Responding;

namespace Obiddable.Library.Electing;

public static class ResponseItemExtensions
{
    public static string GetFormattedId(this ResponseItem responseItem) => responseItem.Id.ToString();
}
