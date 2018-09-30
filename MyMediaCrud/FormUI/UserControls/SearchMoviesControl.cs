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
            MovieSearch movieSearch = new MovieSearch(GetMovieTitleFromTextBox(),  GetYearFromTextBox(), GetMovieRuntimeFromTextBox(), 
                GetActorFirstNameFromTextBox(), GetActorLastNameFromTextBox(), GetDirectorFirstNameFromTextBox(), GetDirectorLastNameFromTextBox());
            return movieSearch;
        }

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

        private string GetMovieTitleFromTextBox()
        {
            return MovieTitleTextBox.Text;
        }

        private TimeSpan? GetMovieRuntimeFromTextBox()
        {
            if ((RuntimeTextBox.Text == "" || RuntimeTextBox.Text == "HH:mm"))
            {
                return null;
            }
            MovieSearchVerifier.IsRuntimeCorrectFormat(RuntimeTextBox.Text);
            return TimeSpan.Parse(RuntimeTextBox.Text);
        }

        private int? GetYearFromTextBox()
        {
            if (YearTextBox.Text == "YYYY"|| YearTextBox.Text == "")
            {
                return null;
            }
            MovieSearchVerifier.IsYearCorrectFormat(YearTextBox.Text);
            return int.Parse(YearTextBox.Text);

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
