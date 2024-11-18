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
using PharApp.About;
using PharApp.Account;
using PharApp.RdlcReports.Stock;
using PharApp.RdlcReports.Account;

namespace PharApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new rptAdjustmentAccountLedger());
            Application.Run(new frmLogin());
        }
    }
}