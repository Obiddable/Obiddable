using Obiddable.Library.Bidding;
using System.ComponentModel;

namespace Obiddable.Win.UI.Bidding.Navigation;

public partial class BidNavigationBoxControl : UserControl
{
    protected Bid _bid;
    public event EventHandler EditClicked;

    [DefaultValue(typeof(Color), "ControlDarkDark")]
    public Color EditButtonColor { get; set; }

    private bool _editEnabled;
    protected bool EditEnabled
    {
        get
        {
            return _editEnabled;
        }
        set
        {
            _editEnabled = value;
            SetButtonEnabled(value);
        }
    }

    public BidNavigationBoxControl()
    {
        InitializeComponent();
        titleLabel.Text = GetType().Name;
    }

    protected void SetClickEventOnControls(Control control)
    {
        control.Click += new EventHandler(_Click);
        foreach (Control c in control.Controls)
        {
            SetClickEventOnControls(c);
        }
    }

    public void SetBid(Bid bid)
    {
        _bid = bid;
        InitLabels();
    }

    protected void SetTitle(string title)
    {
        titleLabel.Text = title;
    }

    private void SetButtonEnabled(bool buttonEnabled)
    {
        editButton.BackColor = EditButtonColor;
        editButton.Enabled = buttonEnabled;
        if (editButton.Enabled)
        {
            editButton.Show();
            panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }
        else
        {
            editButton.Hide();
            panel1.BackColor = Color.LightGray;
        }
    }

    protected virtual void InitLabels() { }

    private void _Click(object sender, EventArgs e) => TriggerEdit();
    private void Panel1_Click(object sender, EventArgs e) => TriggerEdit();

    private void TriggerEdit()
    {
        if (_editEnabled == false)
        {
            return;
        }
        if (EditClicked is null)
        {
            return;
        }
        EditClicked.Invoke(this, null);
    }
}
