using DomeinCore;
using Services;
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
    public partial class AddMovie : Form
    {
        private MovieService movieService { get; set; }
        public AddMovie()
        {
            InitializeComponent();
            movieService = new MovieService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var m = new Movie();
            m.Name = tbMovieName.Text;
            m.Year = int.Parse(tbYear.Text);
            m.Rating = int.Parse(tbRating.Text);

            movieService.Add(m);
        }
    }
}
