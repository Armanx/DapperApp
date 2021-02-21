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
    public partial class Movies : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Movies()
        {
            InitializeComponent();

        }

        private void Movies_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ParentForm.Show();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>();
            var m1 = new Movie() { Id = Guid.NewGuid(), Name = "Matrix", Year = 1999, Rating = 5 };
            movies.Add(m1);
            //bindingSource1.DataSource = movies;

            dgMovies.DataSource = movies;

        }
    }
}
