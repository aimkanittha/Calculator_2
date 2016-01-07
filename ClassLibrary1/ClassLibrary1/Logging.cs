using ClassLibrary1;
using System;
using System.IO;

public class Logging : InterfaceLog
{
    private string source;
    public Logging(string source)
    {
        this.source = source;
    }
    public void writeLog(string history)
    {
        try
        {
            File.AppendAllText(@"" + Path.GetFullPath(".") + "\\LogFile.txt", "\r\n" + System.DateTime.Now.ToLocalTime() + " from " + this.source + "  :  " + history);
        }
        catch (UnauthorizedAccessException e)
        {
        }
    }
}



