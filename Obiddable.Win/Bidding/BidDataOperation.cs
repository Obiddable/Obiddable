using Obiddable.Library.Bidding;
using Obiddable.Library.Operations;
using Obiddable.Library.Validations;

namespace Obiddable.Win.Bidding;

public abstract class BidDataOperation : DataOperation
{
    protected readonly Bid _bid;

    protected BidDataOperation(Bid bid)
    {
        _bid = bid;
    }

    public override void OnDataValidationException(DataValidationException ex)
    {
        FormsMessaging.Instance.ShowDataValidationExceptionError(ex);
    }
    public override void OnException(Exception ex)
    {
        FormsMessaging.Instance.ShowDatabaseOperationError(ex.Message);
    }
}
