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
    public partial class Movies : Form
    {
        public MovieService movieService { get; set; }
        public Movies()
        {
            InitializeComponent();
            movieService = new MovieService();
        }

        private void Movies_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ParentForm.Show();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>();
            movies = movieService.GetAllMovies();
            //bindingSource1.DataSource = movies;

            dgMovies.DataSource = movies;

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
        }
    }
}
