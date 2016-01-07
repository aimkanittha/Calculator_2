
using ClassLibrary1;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Console
    {   [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            if (args.Length == 3)
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                cal.getInput(args[1], args[2], args[0],new Logging("Console"));
                System.Console.WriteLine(cal.calculate());
            }
            else if (args.Length == 0)
            {
              
                System.Diagnostics.Process.Start(@"" + Path.GetFullPath(".") + "WindowsFormsApplication1.exe");
                System.Console.WriteLine("This is WindowForm");
                
            }
            else
                System.Console.WriteLine("It's not match with pattern : -operater and 2 input");
        }
    }
}
