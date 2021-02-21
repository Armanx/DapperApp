using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using DomeinCore;

namespace DapperApp.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {

            var repo = new Data.Repository<Actor>();
            //var x = await r.GetItemByIdAsync3(Guid.Parse("67367000-B0B0-4898-BD0F-CA8DA41DAEF4"));
            //var y = r.GetItemById3(Guid.Parse("67367000-B0B0-4898-BD0F-CA8DA41DAEF4"));
            var listOfActors = repo.GetAll();
            var listOFActorsAsync = await repo.GetAllAsync();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
