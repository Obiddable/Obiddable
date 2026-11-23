using Obiddable.Library.Bidding;
using Obiddable.Library.EF.Cataloging;
using Obiddable.Library.EF.Responding;
using Obiddable.Library.Electing;
using Obiddable.Win.Configuration;
using Obiddable.Win.IO;

namespace Obiddable.Win.Electing;

public static class ElectionsExports
{
    private static readonly ExportFileNameFactory _fileNameGetter;
    private static readonly ElectionsConversions _electionsConversions;

    static ElectionsExports()
    {
        _fileNameGetter = new ExportFileNameFactory();
        _electionsConversions = new ElectionsConversions(new EFCatalogingRepo(), new EFRespondingRepo());
    }

    public static void ExportElectionsToCSV(Bid bid)
    {
        string fileName = _fileNameGetter.BuildFileName(bid, "elections", "csv", "", DateTime.Now);
        string data = _electionsConversions.ConvertElectionsToCSV(bid.Id);
        string title = "Save Elections Export";
        FileHelpers.SaveCSV(fileName, data, title, UserConfiguration.Instance.SupressFileLocationSelectDialog);

        ElectingMessaging.Instance.ShowElectionExportSuccess();
    }
}
