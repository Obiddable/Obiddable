using Obiddable.Win.Library;
using System.Configuration;

namespace Obiddable.Win.UI;

public partial class ChooseDataSourceForm : Form
{
    public ChooseDataSourceForm()
    {
        InitializeComponent();
    }

    private void ReadData()
    {
        var config = UserConfiguration.Instance;

        if (config.DataSourceType == DataSourceType.Sqlite)
        {
            sqliteBrowseButton.Enabled = true;
            sqliteRadioButton.Checked = true;

            if (!File.Exists(config.DataSourceSqliteFilePath ?? string.Empty))
            {
                MessageBox.Show(
                    "The configured SQLite database file was not found. Please select a valid file.",
                    "File Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                sqliteFilePathTextBox.Text = string.Empty;
            }
            else
            {
                sqliteFilePathTextBox.Text = config.DataSourceSqliteFilePath ?? string.Empty;
            }
        }
        else if (config.DataSourceType == DataSourceType.MsSql)
        {
            sqliteBrowseButton.Enabled = false;
            msSqlRadioButton.Checked = true;
            msSqlConnectionStringTextBox.Text =
                config.DataSourceMsSqlConnectionString ?? string.Empty;
        }
        else
        {
            sqliteBrowseButton.Enabled = true;
            sqliteRadioButton.Checked = true;
            sqliteFilePathTextBox.Text = string.Empty;
        }
    }

    private void ChooseDataSourceForm_Load(object sender, EventArgs e)
    {
        ReadData();
    }

    private void MsSqlRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        sqliteRadioButton.Checked = !msSqlRadioButton.Checked;
        msSqlConnectionStringTextBox.Enabled = true;
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

    private void SaveChangesButton_Click(object sender, EventArgs e)
    {
        if (!sqliteRadioButton.Checked && !msSqlRadioButton.Checked)
        {
            return;
        }

        if (sqliteRadioButton.Checked)
        {
            if (string.IsNullOrWhiteSpace(sqliteFilePathTextBox.Text))
            {
                MessageBox.Show(
                    "Please provide a valid SQLite database file path.",
                    "Invalid File Path",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            UserConfiguration.Instance.DataSourceType = DataSourceType.Sqlite;
            UserConfiguration.Instance.DataSourceSqliteFilePath = sqliteFilePathTextBox.Text;
            UserConfiguration.Instance.DataSourceMsSqlConnectionString = null;
        }
        else if (msSqlRadioButton.Checked)
        {
            MessageBox.Show("This feature is not yet implemented.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            
            if (string.IsNullOrWhiteSpace(msSqlConnectionStringTextBox.Text))
			{
				MessageBox.Show(
					"Please provide a valid Microsoft SQL connection string.",
					"Invalid Connection String",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

            UserConfiguration.Instance.DataSourceType = DataSourceType.MsSql;
            UserConfiguration.Instance.DataSourceMsSqlConnectionString =
                msSqlConnectionStringTextBox.Text;
            UserConfiguration.Instance.DataSourceSqliteFilePath = null;
        }
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        if (
            UserConfiguration.Instance.DataSourceType == DataSourceType.Unspecified
            && MessageBox.Show(
                "No data source is configured. The application cannot run without a data source configured. Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.No
        )
        {
            return;
        }
        Close();
    }

    private void SqliteRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        msSqlRadioButton.Checked = !sqliteRadioButton.Checked;
		UpdateRadioButtons();
	}

	private void SqliteBrowseButton_Click(object sender, EventArgs e)
	{
		// Ask the user what they want to do
		var result = MessageBox.Show(
			"Do you want to create a new SQLite database?\nClick No to open an existing one.",
			"SQLite Database",
			MessageBoxButtons.YesNoCancel,
			MessageBoxIcon.Question
		);

		if (result == DialogResult.Cancel)
			return; // user aborted

		if (result == DialogResult.Yes)
		{
			// User wants to create a new database
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "SQLite Database Files (*.sqlite;*.db)|*.sqlite;*.db|All Files (*.*)|*.*";
			saveFileDialog.Title = "Create New SQLite Database";
			saveFileDialog.DefaultExt = "sqlite";
			saveFileDialog.AddExtension = true;
			saveFileDialog.OverwritePrompt = false;
            saveFileDialog.FileName = "obiddable_bidding_database";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = saveFileDialog.FileName;

				if (File.Exists(path))
				{
					MessageBox.Show(
						"Error: File already exists. You selected an existing file while trying to create a new database. Operation cancelled.",
						"File Exists",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
					return;
				}

				sqliteFilePathTextBox.Text = path;
			}
		}
		else if (result == DialogResult.No)
		{
			// User wants to open an existing database
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "SQLite Database Files (*.sqlite;*.db)|*.sqlite;*.db|All Files (*.*)|*.*";
			openFileDialog.Title = "Select Existing SQLite Database";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				sqliteFilePathTextBox.Text = openFileDialog.FileName;
			}
		}
	}



}
