using System.Configuration;
using Ccd.Bidding.Manager.Library.EF;
using Ccd.Bidding.Manager.Library.EF.Bidding.Electing;
using Ccd.Bidding.Manager.Win.Library;
using Ccd.Bidding.Manager.Win.UI;

namespace Ccd.Bidding.Manager.Win;

static class Program
{
   /// <summary>
   /// The main entry point for the application.
   /// </summary>
   [STAThread]
   static void Main()
   {
      var appDataPath = Path.Combine(
         Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
         typeof(Program).Assembly.GetName().Name!
      );
      if (!Directory.Exists(appDataPath))
      {
         Directory.CreateDirectory(appDataPath);
      }
      var configurationFilePath = Path.Combine(appDataPath, "config.csv");
      var databaseFilePath = Path.Combine(appDataPath, "database.sqlite");

      ElectionsConversionService.Disabled = true;

      UserConfiguration.Instance = new UserConfiguration(configurationFilePath);
      UserConfiguration.Instance.SetEpplusLicense();

      Dbc.ConnectionString = $"Data Source={databaseFilePath}";
      using (var context = new Dbc())
      {
         context.Database.EnsureCreated();
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new HostForm());
   }
}
