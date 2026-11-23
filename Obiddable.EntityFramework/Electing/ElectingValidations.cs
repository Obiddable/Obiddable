using Obiddable.Library.Validations;

namespace Obiddable.Library.EF.Electing;

public static class ElectingValidations
{
    public static void Validate_UpdateResponseItem_Elect(this Dbc dbc, int itemId, int responseItemId, string reasonElected)
    {
        if (reasonElected is null)
        {
            throw new DataValidationException("reason elected cannot be null");
        }
    }
}
