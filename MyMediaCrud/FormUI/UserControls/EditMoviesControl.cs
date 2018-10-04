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
    public partial class EditMoviesControl : UserControl
    {
        private Movie selectedMovie;
        public event EventHandler MovieUpdate_Event;

        public EditMoviesControl()
        {
            InitializeComponent();
        }
        
        private void SetTextBoxes(Movie movie)
        {
            MovieTitleTextBox.Text = movie.Title.Trim();
            RuntimeTextBox.Text = movie.Runtime.ToString().Trim();
            YearTextBox.Text = movie.Year.ToString().Trim();
            DirectorTextBox.Text = movie.Director.ToString().Trim();
        }

        private void UpdateMovieBtn_Click(object sender, EventArgs e)
        {

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
            return MovieTitleTextBox.Text;
        }

        private string GetDirectorFromTextBox()
        {
            return DirectorTextBox.Text;
        }

        public Movie BuildMovieFromTextBoxes()
        {
            if(selectedMovie == null)
            {
                throw new Exception();
            }
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
    }
}
