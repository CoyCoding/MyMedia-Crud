using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Movie> Movies = new List<Movie>();

        public Dashboard()
        {
            InitializeComponent();

        }

        private void ShowAllMoviesBtn_Click(object sender, EventArgs e)
        {
            DataAccessSelect db = new DataAccessSelect();
            Movies = db.GetMovies();

            UpdateList();
        }

        private void SearchByDirectorBtn_Click(object sender, EventArgs e)
        {
            DataAccessSelect db = new DataAccessSelect();
            try
            {
                Movies = db.GetMovieByDirector(DirFirstNameTextBox.Text, DirLastNameTextBox.Text);
                UpdateList();
            }
            catch
            {
                MessageBox.Show("No Director Entry was made");
            }
            
        }

        private void UpdateList()
        {
            MovieListbox.DataSource = Movies;
            MovieListbox.DisplayMember = "Info";
        }

        private void SearchByActorBtn_Click(object sender, EventArgs e)
        {
            DataAccessSelect db = new DataAccessSelect();
            try
            {
                Movies = db.GetMovieByActor(ActorFirstNameTextBox.Text, ActorLastNameTextBox.Text);
                UpdateList();
            }
            catch
            {
                MessageBox.Show("No Actor Entry was made");
            }
        }
    }
   
}
