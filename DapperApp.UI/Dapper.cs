using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using DomeinCore;

namespace DapperApp.UI
{
    public partial class Dapper : Form
    {
        private string ConnectionString;

        private string defaultDbConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;";

        public DapperPlus dapperPlus { get; set; }
        public Dapper()
        {
            InitializeComponent();
            this.ConnectionString = defaultDbConnectionString;
            dapperPlus = new DapperPlus(ConnectionString);
            tbOutWindows.Text = $"ConnectionString is set to default { defaultDbConnectionString}";
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {

            ConnectionString = tbArguments.Text;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                tbOutWindows.Text = "Please provide valid connection string or use commando : -default";
                return;
            }
            try
            {
                if (tbArguments.Text.Contains("-default"))
                {
                    ConnectionString = defaultDbConnectionString;
                    dapperPlus = new DapperPlus(ConnectionString);
                    dapperPlus.CreateDB("DefaultDapperPlusDb");
                }
                else
                {
                    dapperPlus.CreateDB("DefaultDapperPlusDb", ConnectionString);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            tbOutWindows.Text = "";
            tbOutWindows.Text += $"Database with connection string : {ConnectionString} has been created";
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            var m = new Movie();
            //dapperPlus.CreateTable(m.GetType(), dapperPlus.ConnectionString);
            var convType = new ConvertionTypes();
            dapperPlus.CreateTable(convType.GetType(), dapperPlus.ConnectionString);
        }

        private void btnSetInitiCatalog_Click(object sender, EventArgs e)
        {
            tbOutWindows.Text = dapperPlus.SetInitialCatalog("DefaultDapperPlusDb");
        }
    }
}
