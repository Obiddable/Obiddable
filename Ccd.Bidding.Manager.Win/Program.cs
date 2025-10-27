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
      DisableElectionsConversionService();
      InitializeUserConfiguration();
      SetDbcConnectionString();
      EnsureDatabaseCreated();
      RunApplication();

      static void DisableElectionsConversionService()
      {
         ElectionsConversionService.Disabled = true;
      }
      static void InitializeUserConfiguration()
      {
         var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         UserConfiguration.Instance = new UserConfiguration(
            myDocumentsPath + "//ccd.bm.win.config.csv"
         );
         UserConfiguration.Instance.SetEpplusLicense();
      }
      static void SetDbcConnectionString()
      {
         var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
         var dbPath = Path.Combine(appDataPath, typeof(Program).Assembly.FullName, "bidding.db");

         // Ensure directory exists
         Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

         Dbc.ConnectionString = $"Data Source={dbPath}";

         Dbc.ConnectionString = connectionString;
      }

      static void EnsureDatabaseCreated()
      {
         using (var context = new Dbc())
         {
            context.Database.EnsureCreated();
         }
      }

      static void RunApplication()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new HostForm());
      }
   }
}
