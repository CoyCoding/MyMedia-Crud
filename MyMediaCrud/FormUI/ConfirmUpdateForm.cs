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
    public partial class ConfirmUpdateForm : Form
    {
        public ConfirmUpdateForm(Movie orginalMovie, Movie updatedMovie)
        {
            InitializeComponent();

            UpdateConfirmationLabel.Text = $"Confirm Update of:\nOriginal: {orginalMovie.ToString()}\nUpdate: {updatedMovie.ToString()}";
        }


    }
}
