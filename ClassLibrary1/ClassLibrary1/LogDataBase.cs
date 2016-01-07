

using System;
using System.IO;

namespace ClassLibrary1
{
    class LogDataBase : InterfaceLog
    {
        private string source;
        public LogDataBase(string source)
        {
            this.source = source;
        }
        public void writeLog(string history)
        {
            if (source.Equals("Database"))
            {
                try
                {
                    File.AppendAllText(@"" + Path.GetFullPath(".") + "\\DatabaseFile.txt", "\r\n" + System.DateTime.Now.ToLocalTime() + " from " + this.source + "  :  " + history);
                }
                catch (UnauthorizedAccessException e)
                {
                }
            }
        }
    }
}
