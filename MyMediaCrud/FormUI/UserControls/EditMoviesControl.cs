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
        public EditMoviesControl()
        {
            InitializeComponent();
        }

        public void SetTextBoxes(Movie movie)
        {
            MovieTitleTextBox.Text = movie.Title;
            RuntimeTextBox.Text = movie.Runtime.ToString();
            YearTextBox.Text = movie.Year.ToString();

        }
 
        
            
    }
}
