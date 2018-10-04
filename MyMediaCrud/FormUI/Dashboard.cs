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
        private List<Movie> Movies = new List<Movie>();
        private List<Director> Directors = new List<Director>();
        private List<Actor> Actors = new List<Actor>();
        private VisablityController ActiveUserControl = new VisablityController();
        private UserControl ActiveControl2 = new UserControl();
        private bool MovieTabOpening = true;
        private bool ActorTabOpening = true;
        private bool DirectorTabOpening = true;
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void MovieDropDownBtn_Click(object sender, EventArgs e)
        { 
            MovieDropDownTimer.Start();
        }
      
        private void ActorDropDownBtn_Click(object sender, EventArgs e)
        {
            ActorDropDownTimer.Start();
        }

        private void DirectorDropDownBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
        }

        private void AllMoviesBtn_Click(object sender, EventArgs e)
        {

            MovieDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = searchMoviesControl;
            LoadAllMoviesToGrid();
        }

        private void MovieUpdate_Event(object sender, EventArgs e)
        {
            try { 
            Movie editedMovie = editMoviesControl1.BuildMovieFromTextBoxes();
            DataAccess db = new DataAccess();
            db.UpdateMovie(editedMovie);
            RefreshGridWith(editedMovie);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoviesSearch_Event(object sender, EventArgs e)
        {
            try
            {
                
                DataAccess db = new DataAccess();
                Movies = db.SearchMovies(searchMoviesControl.BuildMovieSearchFromTextBoxes());
                LoadMoviesToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void SearchByActor_Search(object sender, EventArgs e)
        {
            MessageBox.Show("Not ready");
        }

        private void MoviesByDirector_Click(object sender, EventArgs e)
        {
            MovieDropDownTimer.Start();
            LoadMoviesToGrid();
        }

        private void AllDirectorsBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
            //searchMoviesControl.BringToFront();
            dataGridView2.Columns.Clear();
            DataAccess db = new DataAccess();
            Directors = db.GetDirectors();
            dataGridView2.DataSource = Directors;
            LoadDirectorsToGrid();
        }

        private void SelectRowBtn_Click(object sender, EventArgs e)
        { 

            if (dataGridView2.SelectedRows.Count == 1)
            {
                
                foreach (DataGridViewCell cell in dataGridView2.SelectedCells)

                {
                    MessageBox.Show(cell.Value.ToString());
                    
                }
            }

        }

        private void ActorDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (!ActorTabOpening)
            {
                ActorPanel.Height -= 11;
                if (ActorPanel.Height <= 0)
                {
                    ActorPanel.Height = 0;
                    ActorTabOpening = true;
                    ActorDropDownTimer.Stop();
                }
            }
            else if (ActorTabOpening)
            {
                ActorPanel.Height += 11;
                if (ActorPanel.Height >= 99)
                {
                    ActorPanel.Height = 99;
                    ActorTabOpening = false;
                    ActorDropDownTimer.Stop();
                }
            }
        }

        private void MovieDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (!MovieTabOpening)
            {
                MoviePanel.Height -= 11;
                if (MoviePanel.Height <= 0)
                {
                    MoviePanel.Height = 0;
                    MovieTabOpening = true;
                    MovieDropDownTimer.Stop();
                }
            }
            else if (MovieTabOpening)
            {
                MoviePanel.Height += 11;
                if (MoviePanel.Height >= 99)
                {
                    MoviePanel.Height = 99;
                    MovieTabOpening = false;
                    MovieDropDownTimer.Stop();
                }
            }


        }

        private void DirectorDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (!DirectorTabOpening)
            {
                DirectorPanel.Height -= 11;
                if (DirectorPanel.Height <= 0)
                {
                    DirectorPanel.Height = 0;
                    DirectorTabOpening = true;
                    DirectorDropDownTimer.Stop();
                }
            }
            else if (DirectorTabOpening)
            {
                DirectorPanel.Height += 11;
                if (DirectorPanel.Height >= 132)
                {
                    DirectorPanel.Height = 132;
                    DirectorTabOpening = false;
                    DirectorDropDownTimer.Stop();
                }
            }
        }

        private void LoadMoviesToGrid()
        {
            if (dataGridView2.DataSource.GetType().ToString() == Movies.ToString())
            {
                dataGridView2.DataSource = Movies;
            }
            else
            {
                dataGridView2.DataSource = Movies;
                dataGridView2.Columns.Clear();
                dataGridView2.Columns.Add(idDataGridViewTextBoxColumn);
                dataGridView2.Columns.Add(titleDataGridViewTextBoxColumn);
                dataGridView2.Columns.Add(directorDataGridViewTextBoxColumn);
                dataGridView2.Columns.Add(runtimeDataGridViewTextBoxColumn);
                dataGridView2.Columns.Add(yearDataGridViewTextBoxColumn);
                idDataGridViewTextBoxColumn.Visible = false;
            }
        }

        private void LoadDirectorsToGrid()
        {
            dataGridView2.Columns.Add(idDataGridViewTextBoxColumn);
            dataGridView2.Columns.Add(firstNameDataGridViewTextBoxColumn);
            dataGridView2.Columns.Add(lastNameDataGridViewTextBoxColumn);
            idDataGridViewTextBoxColumn.Visible = false;
        }

        private void ShowAllActorsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (editMoviesControl1.Visible == true && dataGridView2.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                Movie movie = (Movie)selectedRow.DataBoundItem;
                editMoviesControl1.SetSelectedMovie(movie);
            }
        }

        private void EditMoviesBtn_Click(object sender, EventArgs e)
        {
            MovieDropDownTimer.Start();
            LoadAllMoviesToGrid();
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            // ActiveUserControl.SetActiveControl(editMoviesControl1);
        }
       
        private void LoadAllMoviesToGrid()
        {
            DataAccess db = new DataAccess();
            Movies = db.GetAllMovies();
            LoadMoviesToGrid();
        }

        private void RefreshGridWith(Movie editedMovie)
        {
            foreach (Movie movie in Movies)
            {
                if (movie.id == editedMovie.id)
                {
                    if (editedMovie.Title != null)    { movie.Title = editedMovie.Title;}
                    if (editedMovie.Runtime != null)  { movie.Runtime = editedMovie.Runtime; }
                    if (editedMovie.Year != null)     { movie.Year = editedMovie.Year; }
                    if (editedMovie.Director != null) { movie.Director = editedMovie.Director; }
                    dataGridView2.Refresh();
                    break;
                }
            }
        }
    }
   
}
