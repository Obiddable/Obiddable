using Obiddable.Library.Cataloging;
using Obiddable.Library.Responding;
using Obiddable.Library.Validations;
using Obiddable.Win.IO;

namespace Obiddable.Win.Responding;

public static class VendorResponsesImports
{

    public static void ImportVendorResponseFromCSV(VendorResponse vendorResponse, IRespondingRepo respondingRepo, CatalogingService catalogingService)
    {
        string fileName = FileHelpers.OpenFile("Open Vendor Response Import", "csv");
        if (fileName is null)
        {
            return;
        }
        string errors = "";
        VendorResponse vr = File.ReadAllLines(fileName).ConvertCSVToVendorResponse(vendorResponse.Bid.Id, out errors, catalogingService);
        if (errors != "")
        {
            FormsMessaging.Instance.ShowImportError(errors);
        }
        if (vr is null || vr.ResponseItems.Count == 0)
        {
            FormsMessaging.Instance.ShowImportNotCompleted();
            return;
        }
        try
        {
            vr.ResponseItems.ForEach(x => respondingRepo.AddResponseItem_ToVendorResponse(x, vendorResponse.Id));
            VendorResponseMessaging.Instance.ShowResponseItemsImportSuccess(vr.ResponseItems);
        }
        catch (DataValidationException e)
        {
            FormsMessaging.Instance.ShowDataValidationExceptionError(e);
        }
        catch (Exception e)
        {
            FormsMessaging.Instance.ShowDatabaseOperationError(e.Message);
        }
    }
    public static void ImportVendorResponseFromExcel(VendorResponse vendorResponse, IRespondingRepo respondingRepo, CatalogingService catalogingService)
    {
        string fileName = FileHelpers.OpenFile("Open Vendor Response Import", "xlsx");
        if (fileName is null)
        {
            return;
        }

        string errors = "";
        FileInfo file = new FileInfo(fileName);
        VendorResponse vr = VendorResponsesConversions.ConvertExcelFileToVendorResponse(file, vendorResponse.Bid.Id, out errors, catalogingService);

        if (errors != "")
        {
            FormsMessaging.Instance.ShowImportError(errors);
        }

        if (vr is null || vr.ResponseItems.Count == 0)
        {
            FormsMessaging.Instance.ShowImportNotCompleted();
            return;
        }
        try
        {
            vr.ResponseItems.ForEach(x => respondingRepo.AddResponseItem_ToVendorResponse(x, vendorResponse.Id));

            VendorResponseMessaging.Instance.ShowResponseItemsImportSuccess(vr.ResponseItems);
        }
        catch (DataValidationException e)
        {
            FormsMessaging.Instance.ShowDataValidationExceptionError(e);
        }
        catch (Exception e)
        {
            FormsMessaging.Instance.ShowDatabaseOperationError(e.Message);
        }
    }

}
