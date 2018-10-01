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
        MovieSearch movieSearch = new MovieSearch();

        public event EventHandler MovieSearch_Event;

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
            movieSearch.Title = GetMovieTitleFromTextBox();
            movieSearch.Year = GetYearFromTextBox();
            movieSearch.Runtime = GetMovieRuntimeFromTextBox();
            movieSearch.ActorFirstName = GetActorFirstNameFromTextBox();
            movieSearch.ActorLastName = GetActorLastNameFromTextBox();
            movieSearch.DirectorFirstName = GetDirectorFirstNameFromTextBox();
            movieSearch.DirectorLastName = GetDirectorLastNameFromTextBox();
                                                    
            return movieSearch;
        }

        private void RuntimeTextBox_Click(object sender, EventArgs e)
        {
            if (MovieSearchFormValidator.IsDefaultRuntimeValue(RuntimeTextBox.Text))
            {
                RuntimeTextBox.Text = "";
                RuntimeTextBox.ForeColor = Color.Black;
            }
            
        }

        private void YearTextBox_Click(object sender, EventArgs e)
        {
            if (MovieSearchFormValidator.IsDefaultYearValue(YearTextBox.Text))
            {
                YearTextBox.Text = "";
                YearTextBox.ForeColor = Color.Black;
            }
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
    }
    
}
