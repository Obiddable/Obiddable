using Obiddable.Library.Bidding;
using Obiddable.Library.Cataloging;
using Obiddable.Library.EF.Cataloging;
using Obiddable.Library.EF.Requesting;
using Obiddable.Library.EF.Responding;
using Obiddable.Library.Requesting;
using Obiddable.Library.Responding;
using Obiddable.Win.Requesting;

namespace Obiddable.Win.Bidding;

public class ExportBidOperation : BidDataOperation
{
    private readonly ICatalogingRepo _catalogingRepo = new EFCatalogingRepo();
    private readonly IRequestingRepo _requestingRepo = new EFRequestingRepo();
    private readonly IRespondingRepo _respondingRepo = new EFRespondingRepo();
    private readonly RequestMessaging _requestMessaging = new RequestMessaging();
    public ExportBidOperation(Bid bid) : base(bid) { }

    public override bool Confirm()
    {
        return true;
    }

    protected override void RunDataOperation()
    {
        BidsExports.ExportBid(_bid, _respondingRepo, _catalogingRepo, _requestingRepo, _requestMessaging);
    }
}
