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
        
        private VisablityController ActiveUserControl = new VisablityController();
        private bool MovieTabOpening = true;
        private bool ActorTabOpening = true;
        private bool DirectorTabOpening = true;

        public Dashboard()
        {
            InitializeComponent();
        }

        #region Movie Buttons

        private void MovieDropDownBtn_Click(object sender, EventArgs e)
        {
            MovieDropDownTimer.Start();
        }

        private void SearchMoviesBtn_Click(object sender, EventArgs e)
        {

            MovieDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = searchMoviesControl;
            dataGrid1.LoadAllMoviesToGrid();
        }

        private void EditMoviesBtn_Click(object sender, EventArgs e)
        {
            MovieDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            dataGrid1.LoadAllMoviesToGrid();
            editMoviesControl1.SetControlAsEdit();
            SelectedRowChange_Event(sender, e);
        }

        private void AddMovies_Click(object sender, EventArgs e)
        {
            MovieDropDownTimer.Start();
            dataGrid1.LoadAllMoviesToGrid();
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            editMoviesControl1.SetControlAsAdd();
        }

        #endregion

        #region Actor Buttons

        private void ActorDropDownBtn_Click(object sender, EventArgs e)
        {
            ActorDropDownTimer.Start();
        }

        private void ShowAllActorsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ShowAllActorsBtn not ready");
        }

        private void EditActorsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EditActorsBtn not ready");
        }

        private void AddActorsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddActorsBtn not ready");
        }

        #endregion

        #region Director Buttons

        private void DirectorDropDownBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
        }

        private void AllDirectorsBtn_Click(object sender, EventArgs e)
        {
            //DirectorDropDownTimer.Start();
            //DataAccess db = new DataAccess();
            //Directors = db.GetDirectors();
            //dataGrid1.dataGridView.DataSource = Directors;
            //PopulateGridWithDirectors();
        }

        private void EditDirectorsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EditDirectorsBtn not ready");
        }

        private void AddDirectorsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddDirectorsBtn not ready");
        }

        #endregion

        #region DropDown Timers

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
                if (DirectorPanel.Height >= 99)
                {
                    DirectorPanel.Height = 99;
                    DirectorTabOpening = false;
                    DirectorDropDownTimer.Stop();
                }
            }
        }

        #endregion

        private void MovieUpdate_Event(object sender, EventArgs e)
        {
            try
            {
                Movie editedMovie = editMoviesControl1.BuildMovieFromTextBoxes();

                if (IsUpdateConfirmedDialogResult(GetSelectedMovie(), editedMovie))
                {
                    
                    DataAccess db = new DataAccess();
                    db.UpdateMovie(editedMovie);
                    dataGrid1.RefreshGridWith(editedMovie);
                }
             

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
                dataGrid1.Movies = db.SearchMovies(searchMoviesControl.BuildMovieSearchFromTextBoxes());
                dataGrid1.PopulateGridWithMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectRowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(dataGrid1.Movies[0].Title);
            }
            catch (Exception)
            {
                MessageBox.Show("No Movie Selected");
            }
            //if (dataGridView2.SelectedRows.Count == 1)
            //{

            //    foreach (DataGridViewCell cell in dataGridView2.SelectedCells)

            //    {
            //        MessageBox.Show(cell.Value.ToString());

            //    }
            //}

        }

        private void MovieSearchEdit_Event(object sender, EventArgs e)
        {
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            SelectedRowChange_Event(sender, e);
        }

        private void SelectedRowChange_Event(object sender, EventArgs e)
        {
            if (editMoviesControl1.Visible == true && editMoviesControl1.GetCurrentUsage() 
                == (int)ControlUsage.EDIT_MOVIE)
            {
                editMoviesControl1.SetSelectedMovie(GetSelectedMovie());
            }
        }

        private Movie GetSelectedMovie()
        {
            return (Movie)dataGrid1.GetSelectedRow().DataBoundItem;
        }

        private bool IsUpdateConfirmedDialogResult(object original, object update)
        {
            DialogResult confirm = MessageBox.Show($"Confirm Update of:\nOriginal: { original.ToString() }\nUpdate: { update.ToString() }",
             "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }

}  

