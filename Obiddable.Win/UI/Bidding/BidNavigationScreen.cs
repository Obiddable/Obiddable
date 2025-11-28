using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Bidding;
using Obiddable.Win.Library;
using Obiddable.Win.Library.Operations.UI;
using Obiddable.Win.Library.UI;
using Obiddable.Win.UI.Bidding.Cataloging;
using Obiddable.Win.UI.Bidding.Electing;
using Obiddable.Win.UI.Bidding.Purchasing;
using Obiddable.Win.UI.Bidding.Requesting;
using Obiddable.Win.UI.Bidding.Responding;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class BidNavigationScreen : HostScreen
{
    private readonly IBiddingRepo _biddingRepo = new EFBiddingRepo();

    private readonly IHostForm _hostForm;
    private Bid? _bid;
    private readonly ReportsFolderShower _reportsFolderShower = new ReportsFolderShower();
    private readonly ExportsFolderShower _exportsFolderShower = new ExportsFolderShower();
    private readonly HelpScreenShower _helpScreenShower = new HelpScreenShower(new UrlOpener());
	private readonly ConfigMenuShower _configMenuShower = new ConfigMenuShower();

	public BidNavigationScreen(IHostForm hostForm, int bidId)
    {
        _hostForm = hostForm;
        InitializeComponent();
        Load(bidId);
    }

    private void Load(int bidId)
    {
        _bid = _biddingRepo.GetBid(bidId);
        if (_bid is null)
        {
            MessageBox.Show(
                "Bid #{bidId} could not be loaded. Reverting to Bid Maintenance Screen."
            );
            _hostForm.GoBack();
        }
        SetSubTitle();
        InitReportToolstrip();
        InitBoxes();
    }

    private void InitReportToolstrip()
    {
        reportsControl.SetBid(_bid);
    }

    private void InitBoxes()
    {
        this.GetAllNestedControls()
            .OfType<BidNavigationBoxControl>()
            .ToList()
            .ForEach(x => x.SetBid(_bid));
    }

    private void SetSubTitle()
    {
        string title = $"Bid: {_bid.Name}";
        this.Text = title;
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        ClearWorkingBid();
        _hostForm.GoBack();
    }

    private void ClearWorkingBid()
    {
        UserConfiguration.Instance.WorkingBidId = null;
    }

    private void ItemNavigationBoxControl1_EditClicked(object sender, EventArgs e) =>
        ForwardToScreen(new ItemMaintenanceScreen(_hostForm, _bid.Id));

    private void RequestorsNavigationControl1_EditClicked(object sender, EventArgs e) =>
        ForwardToScreen(new RequestorMaintenanceScreen(_hostForm, _bid.Id));

    private void VendorResponseNavigationBoxControl1_EditClicked(object sender, EventArgs e) =>
        ForwardToScreen(new VendorResponseMaintenanceScreen(_hostForm, _bid.Id));

    private void ElectionNavigationBoxControl1_EditClicked(object sender, EventArgs e) =>
        ForwardToScreen(new LegacyElectionMaintenanceScreen(_hostForm, _bid.Id));

    private void PurchaseOrderNavigationBoxControl1_EditClicked(object sender, EventArgs e) =>
        ForwardToScreen(new PurchaseOrderMaintenanceScreen(_hostForm, _bid.Id));

    private void ForwardToScreen(HostScreen nextScreen) => _hostForm.GoForward(nextScreen);

    private void BidNavigationScreen_SizeChanged(object sender, EventArgs e)
    {
        SuspendLayout();

        int topOffset = topPanel.Height + topToolStrip.Height;
        int spaceWidth = this.ClientSize.Width;
        int spaceHeight = this.ClientSize.Height - topOffset;
        int spaceHeightHalf = spaceHeight / 2;

        int boxHeight = centeredPanel.Height;
        int boxHeightHalf = boxHeight / 2;

        int leftPos = (spaceWidth - centeredPanel.Width) / 2;
        int topPos = topOffset + spaceHeightHalf - boxHeightHalf;

        centeredPanel.Left = leftPos;
        centeredPanel.Top = topPos;
        ResumeLayout();
    }

    private void ExportsButton_Click(object sender, EventArgs e) => _exportsFolderShower.Run();

    private void ReportsButton_Click(object sender, EventArgs e) => _reportsFolderShower.Run();

    private void RefreshButton_Click(object sender, EventArgs e) => RefreshScreen();

    private void HelpButton_Click(object sender, EventArgs e) => _helpScreenShower.Run();

    public override void Refresh()
    {
        RefreshScreen();
        base.Refresh();
    }

    private void RefreshScreen()
    {
        if (_bid is not null)
            Load(_bid.Id);
    }
}
