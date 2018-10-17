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
    public partial class SearchMoviesControl : UserControl
    {
        
        public event EventHandler MovieSearch_Event;

        public event EventHandler MovieSearchEdit_Event;

        public SearchMoviesControl()
        {
            InitializeComponent();
        }

        private void SearchMovieBtn_Click(object sender, EventArgs e)
        {
            if (MovieSearch_Event != null)
            {
                MovieSearch_Event(this, new EventArgs());
            }
        }
        
        public MovieSearch BuildMovieSearchFromTextBoxes()
        {
            MovieSearch movieSearch = new MovieSearch
            {
                Title = GetMovieTitleFromTextBox(),
                Year = GetYearFromTextBox(),
                Runtime = GetMovieRuntimeFromTextBox(),
                ActorFirstName = GetActorFirstNameFromTextBox(),
                ActorLastName = GetActorLastNameFromTextBox(),
                DirectorFirstName = GetDirectorFirstNameFromTextBox(),
                DirectorLastName = GetDirectorLastNameFromTextBox()
            };

            return movieSearch;
        }

        private string GetMovieTitleFromTextBox()
        {
            return MovieTitleTextBox.Text;
        }

        private TimeSpan? GetMovieRuntimeFromTextBox()
        {
            if (MovieSearchFormValidator.IsValidMovieRuntime(RuntimeTextBox.Text))
            {
                return TimeSpan.Parse(RuntimeTextBox.Text);
            }
            return null;
            
        }

        private int? GetYearFromTextBox()
        {
           
           if(MovieSearchFormValidator.IsValidMovieYear(YearTextBox.Text))
           {
                return int.Parse(YearTextBox.Text);
           }
            return null;

        }

        private string GetActorFirstNameFromTextBox()
        {
            return ActorfNameTextBox.Text;
        }

        private string GetActorLastNameFromTextBox()
        {
            return ActorlNameTextBox.Text;
        }

        private string GetDirectorFirstNameFromTextBox()
        {
            return DirectorfNameTextBox.Text;
        }

        private string GetDirectorLastNameFromTextBox()
        {
            return DirectorlNameTextBox.Text;
        }

        private void EditMovieBtn_Click(object sender, EventArgs e)
        {
            if (MovieSearchEdit_Event != null)
            {
                MovieSearchEdit_Event(this, new EventArgs());
            }
        }

        #region TextBox Styling

        private void RuntimeTextBox_Click(object sender, EventArgs e)
        {
            RuntimeTextBox.Text = "";
            RuntimeTextBox.ForeColor = Color.Black;

        }

        private void YearTextBox_Click(object sender, EventArgs e)
        {
            YearTextBox.Text = "";
            YearTextBox.ForeColor = Color.Black;
        }

        #endregion
    }
}
