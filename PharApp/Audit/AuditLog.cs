using Microsoft.VisualBasic.Logging;
using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PharApp.Audit
{
    public partial class AuditLog : Form
    {
        public AuditLog()
        {
            InitializeComponent();
        }

        private async void AuditLog_Load(object sender, EventArgs e)
        {
            await LoadLogs();
        }


        private async Task LoadLogs() 
        {
            var auditLogBal = new BAL.AuditLog(Helper.GetConnectionStringFromSettings());
            var auditLogList = await auditLogBal.GetLogsAsync();
            StringBuilder sb = new StringBuilder();
            foreach (var auditLog in auditLogList)
            {
                sb.AppendLine($"************************##  {auditLog.ChangeDate.ToString("MM/dd/yyyy hh:mm tt")} ##************************");
                sb.AppendLine();
                sb.AppendLine($"{auditLog.ChangeDescription}");
                sb.AppendLine();
            }
            richTextBoxAditLogs.Text = sb.ToString();
        }
    }
}
