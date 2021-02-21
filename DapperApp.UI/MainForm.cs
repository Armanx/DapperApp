using Data;
using DomeinCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            frmMovies = new Movies();
        }

        private Movies frmMovies { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new Repository<Actor>();
            List<Actor> actors = new List<Actor>();

            var a1 = new Actor() { Id = Guid.Parse("4974743D-4E14-4AEB-8DCC-8721EFEBFDE5"), LastName = "the last name" };
            //var ActorToBeDeleted = repo.GetItemById(Guid.Parse("67367000-B0B0-4898-BD0F-CA8DA41DAEF4"));

            //repo.HardDeleteById(Guid.Parse("935957B6-8CB9-451E-80F2-7407D55EEFA4"));



        }

        private void btnMovies_Click(object sender, EventArgs e)
        {

            frmMovies.Show();
            var p = frmMovies.Controls.Find(this.Name, false);


        }
    }
}
