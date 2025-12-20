

using Microsoft.Data.SqlClient;

namespace Obiddable.Library.EF;

// ADDED: New class to encapsulate MS SQL specific logic
public static class MsSqlDataSourceHelper
{
	private const int CONNECTION_TIMEOUT_IN_MILLISECONDS = 20_000;
	public static bool TestConnection(string connectionString, out string errorMessage)
	{
		errorMessage = string.Empty;

		if (string.IsNullOrWhiteSpace(connectionString))
		{
			errorMessage = "Connection string cannot be empty.";
			return false;
		}
		try
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				return true;
			}
		}
		catch (Exception ex)
		{
			errorMessage = ex.Message;
			return false;
		}
	}
}
// END ADDED