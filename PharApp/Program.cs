using PharApp.Customer;
using PharApp.Inventory;
using PharApp.Main;
using PharApp.Purchase;
using PharApp.Sale;
using PharApp.Settings;
using PharApp.Users;
using PharApp.RdlcReports.Purchase;
using PharApp.RdlcReports.Sale;
using PharApp.Audit;
using PharApp.Backup;

namespace PharApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}