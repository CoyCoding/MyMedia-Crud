using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class EditMoviesControl :  UserControl
    {
        private Movie selectedMovie;

        public event EventHandler MovieUpdate_Event;

        public event EventHandler MovieAdd_Event;

        private int CurrentUsage;

        public EditMoviesControl()
        {
            InitializeComponent();
        }
        
        private void SetTextBoxes(Movie movie)
        {
            if (movie != null)
            {
                MovieTitleTextBox.Text = movie.Title.Trim();
                RuntimeTextBox.Text = movie.Runtime.ToString().Trim();
                YearTextBox.Text = movie.Year.ToString().Trim();
                DirectorTextBox.Text = movie.Director.ToString().Trim();
            }
            else
            {
                MovieTitleTextBox.Text = "";
                RuntimeTextBox.Text = "";
                YearTextBox.Text = "";
                DirectorTextBox.Text = "";
            }
        }

        private void UpdateMovieBtn_Click(object sender, EventArgs e)
        {
            if(RuntimeTextBox.Text == "HH:mm") { RuntimeTextBox.Text = "0"; }
            if (MovieUpdate_Event != null)
            {

                MovieUpdate_Event(this, new EventArgs());
            }
        }

        private int? GetYearFromTextBox()
        {
           
            if (MovieSearchFormValidator.IsValidMovieYear(YearTextBox.Text))
            {
                return int.Parse(YearTextBox.Text);
            }
            return null;

        }

        private TimeSpan? GetMovieRuntimeFromTextBox()
        {
            if (MovieSearchFormValidator.IsValidMovieRuntime(RuntimeTextBox.Text))
            {
                return TimeSpan.Parse(RuntimeTextBox.Text);
            }
            return null;

        }

        private string GetMovieTitleFromTextBox()
        {
            if(MovieTitleTextBox.Text == "")
            {
                throw new Exception("Movie must have a title");
            }
            return MovieTitleTextBox.Text;
        }

        private string GetDirectorFromTextBox()
        {
            return DirectorTextBox.Text;
        }

        public Movie BuildMovieFromTextBoxes()
        {
            if(CurrentUsage == (int)ControlUsage.ADD_MOVIE)
            {
                return BuildMovieForAdd();
            }
            else if (selectedMovie != null 
                && CurrentUsage == (int)ControlUsage.EDIT_MOVIE)
            {
                return BuildMovieForEdit();
            }
            else
            {
                throw new Exception();
            } 
        }

        private Movie BuildMovieForAdd()
        {
            Movie editedMovie = new Movie
            {
                Title = GetMovieTitleFromTextBox(),
                Year = GetYearFromTextBox(),
                Runtime = GetMovieRuntimeFromTextBox(),
                Director = new Director(GetDirectorFromTextBox())
            };
            return editedMovie;
        }

        private Movie BuildMovieForEdit()
        {
            Movie editedMovie = new Movie
            {
                id = selectedMovie.id,
                Title = GetMovieTitleFromTextBox(),
                Year = GetYearFromTextBox(),
                Runtime = GetMovieRuntimeFromTextBox(),
                Director = new Director(GetDirectorFromTextBox())
            };

            return editedMovie;
        }

        public void SetSelectedMovie(Movie movie)
        {
            selectedMovie = movie;
            SetTextBoxes(selectedMovie);
        }

        public void SetControlAsEdit()
        {
            if (CurrentUsage != (int)ControlUsage.EDIT_MOVIE)
            {
                CurrentUsage = (int)ControlUsage.EDIT_MOVIE;
                EditMovieLabel.Text = "Edit Movie";
                UpdateMovieBtn.Visible = true;
                AddMovieBtn.Visible = false;
            }

        }

        public void SetControlAsAdd()
        {
            if (CurrentUsage != (int)ControlUsage.ADD_MOVIE)
            { 
                CurrentUsage = (int)ControlUsage.ADD_MOVIE;
                EditMovieLabel.Text = "Add Movie";
                AddMovieBtn.Visible = true;
                UpdateMovieBtn.Visible = false;
                SetTextBoxes(null);
            }
        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            if (MovieAdd_Event != null)
            {

                MovieAdd_Event(this, new EventArgs());
            }
            
        }

        public int GetCurrentUsage()
        {
            return CurrentUsage;
        }
    }
}
