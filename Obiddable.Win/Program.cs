using Obiddable.Library.EF;
using Obiddable.Library.EF.Bidding.Electing;
using Obiddable.Win.Library;
using Obiddable.Win.Library.Operations.UI;
using Obiddable.Win.UI;

namespace Obiddable.Win;

static class Program
{
    public static readonly string DefaultObiddableDocumentsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Obiddable"
    );

    public static readonly string DefaultReportsDirectoryPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Obiddable",
        "Reports"
    );
    public static readonly string DefaultExportsDirectoryPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Obiddable",
        "Exports"
    );

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        if (
            !Directory.Exists(DefaultObiddableDocumentsPath)
            || !Directory.Exists(DefaultReportsDirectoryPath)
            || !Directory.Exists(DefaultExportsDirectoryPath)
        )
        {
			try
			{
				Directory.CreateDirectory(DefaultObiddableDocumentsPath);
				Directory.CreateDirectory(DefaultReportsDirectoryPath);
				Directory.CreateDirectory(DefaultExportsDirectoryPath);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to create default folders: {ex.Message}");
			}
		}

        // Initialize User Configuration
        var configurationFilePath = Path.Combine(DefaultObiddableDocumentsPath, "config.csv");
        UserConfiguration.Instance = new UserConfiguration(configurationFilePath);
        UserConfiguration.Instance.SetEpplusLicense();

        // Disable elections conversion service in Win client
        ElectionsConversionService.Disabled = true;

        // Set up application
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Initialize Database
        if (
            UserConfiguration.Instance.DataSourceType is DataSourceType.Unspecified
            || (
                UserConfiguration.Instance.DataSourceType is DataSourceType.Sqlite
                && !File.Exists(UserConfiguration.Instance.DataSourceSqliteFilePath)
            )
        )
        {
            new ChooseDataSourceShower().Run();
            if (UserConfiguration.Instance.DataSourceType is DataSourceType.Unspecified)
            {
                Application.Exit();
                return;
            }
        }
        if (UserConfiguration.Instance.DataSourceType == DataSourceType.Sqlite)
        {
            var databaseFilePath = UserConfiguration.Instance.DataSourceSqliteFilePath;
            Dbc.ConnectionString = $"Data Source={databaseFilePath}";
            using (var context = new Dbc())
            {
                context.Database.EnsureCreated();
            }
        }
        else if (UserConfiguration.Instance.DataSourceType == DataSourceType.MsSql)
        {
            // do nothing now
        }

        if (
            UserConfiguration.Instance.ReportsDirectory is null
            || UserConfiguration.Instance.ExportsDirectory is null
        )
        {
            new ConfigMenuShower().Run();
        }

        Application.Run(new HostForm());
    }
}
