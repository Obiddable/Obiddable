namespace Obiddable.Library.Cataloging;

public class ImportLineErrorException : Exception
{
    public ImportLineErrorException(string message) : base(message)
    {
    }
}
