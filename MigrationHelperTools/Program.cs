using System;
using System.Windows.Forms;

namespace MigrationHelperTools
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Clipboard.SetDataObject(DateTime.Now.ToString("yyyyMMddHHmm"), true, 3, 20);
        }
    }
}
