using Obiddable.Win.Library;
using System.Configuration;

namespace Obiddable.Win.UI;


public partial class ChooseDataSourceForm : Form
{
    public ChooseDataSourceForm()
    {
        InitializeComponent();

        ReadData();
    }

    private void ReadData()
    {
        var config = UserConfiguration.Instance;

        if (config.DataSourceType == DataSourceType.Sqlite)
        {
            sqliteRadioButton.Checked = true;
            sqliteFilePathTextBox.Text = config.DataSourceSqliteFilePath ?? string.Empty;
        }
        else if (config.DataSourceType == DataSourceType.MsSql)
        {
            msSqlRadioButton.Checked = true;
            msSqlConnectionStringTextBox.Text = config.DataSourceMsSqlConnectionString ?? string.Empty;
        }
        else
        {
            throw new InvalidOperationException("DataSourceType is not set in UserConfiguration.");
        }
    }

    private void ChooseDataSourceForm_Load(object sender, EventArgs e)
    {

    }

    private void msSqlRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        sqliteRadioButton.Checked = !msSqlRadioButton.Checked;
        UpdateRadioButtons();
    }

    private void UpdateRadioButtons()
    {
        if (sqliteRadioButton.Checked)
        {
            sqliteBrowseButton.Enabled = true;
            msSqlConnectionStringTextBox.Enabled = false;
        }
        else if (msSqlRadioButton.Checked)
        {
            sqliteBrowseButton.Enabled = false;
            msSqlConnectionStringTextBox.Enabled = true;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    private void saveChangesButton_Click(object sender, EventArgs e)
    {
        
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {

    }

    private void reportsFolderButton_Click(object sender, EventArgs e)
    {

    }

    private void sqliteRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        msSqlRadioButton.Checked = !sqliteRadioButton.Checked;
    }
}
