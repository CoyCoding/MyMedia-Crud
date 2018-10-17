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
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            dataGrid1.LoadAllMoviesToGrid();
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
            ActorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = actorUserControl;
            dataGrid1.LoadAllActorsToGrid();
            actorUserControl.SetControlAsSearch();
        }

        private void EditActorsBtn_Click(object sender, EventArgs e)
        {
            ActorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = actorUserControl;
            dataGrid1.LoadAllActorsToGrid();
            actorUserControl.SetControlAsEdit();
            SelectedRowChange_Event(sender, e);
        }

        private void AddActorsBtn_Click(object sender, EventArgs e)
        {
            ActorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = actorUserControl;
            dataGrid1.LoadAllActorsToGrid();
            actorUserControl.SetControlAsAdd();
        }

        #endregion

        #region Director Buttons

        private void DirectorDropDownBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
        }

        private void AllDirectorsBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = directorsUserControl;
            dataGrid1.LoadAllDirectorsToGrid();
            directorsUserControl.SetControlAsSearch();
        }

        private void EditDirectorsBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = directorsUserControl;
            dataGrid1.LoadAllDirectorsToGrid();
            directorsUserControl.SetControlAsEdit();
            SelectedRowChange_Event(sender, e);
        }

        private void AddDirectorsBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
            ActiveUserControl.ActiveUserControl = directorsUserControl;
            dataGrid1.LoadAllDirectorsToGrid();
            directorsUserControl.SetControlAsAdd();
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

        #region Movie Control Events

        private void MovieUpdate_Event(object sender, EventArgs e)
        {
            try
            {
                Movie editedMovie = editMoviesControl1.BuildMovieFromTextBoxes();
                Movie originaMovie = (Movie)dataGrid1.GetSelectedGridObject();
                if (IsUpdateConfirmedDialogResult(originaMovie, editedMovie))
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

        private void MovieDelete_Event(object sender, EventArgs e)
        {
            try
            {
                Movie originaMovie = (Movie)dataGrid1.GetSelectedGridObject();
                if (IsDeleteConfirmedDialogResult(originaMovie))
                {
                    DataAccess db = new DataAccess();
                    db.DeleteMovie(originaMovie);
                    dataGrid1.PopulateGridWithMovies(); 
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

        private void MovieSearchEdit_Event(object sender, EventArgs e)
        {
            ActiveUserControl.ActiveUserControl = editMoviesControl1;
            editMoviesControl1.SetControlAsEdit();
            SelectedRowChange_Event(sender, e);
        }

        private void MovieAdd_Event(object sender, EventArgs e)
        {

            try
            {
                Movie editedMovie = editMoviesControl1.BuildMovieFromTextBoxes();
                if (editedMovie.IsMovieInfoNull() && editedMovie.IsDirectorInfoNull())
                {
                    throw new Exception("no fields filled out");
                }
                else if (editedMovie.IsMovieInfoNull())
                {
                    throw new Exception("No movie info given");
                }
                else if (editedMovie.IsDirectorInfoNull())
                {
                    DataAccess db = new DataAccess();
                    db.AddMovie(editedMovie);
                }
                else if (IsAddDataConfirmedDialogResult(editedMovie))
                {
                    MessageBox.Show($"{editedMovie} fake added");
                    DataAccess db = new DataAccess();
                    db.AddMovieWithDirector(editedMovie);
                    dataGrid1.RefreshGridWith(editedMovie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Director Control Events

        private void SearchDirector_Event(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();
                dataGrid1.Directors = db.SearchDirectors(directorsUserControl.BuildDirectorFromTextBoxes());
                dataGrid1.PopulateGridWithDirectors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDirector_Event(object sender, EventArgs e)
        {
            try
            {
                Director editedDirector = directorsUserControl.BuildDirectorFromTextBoxes();
                Director orginalDirector = (Director)dataGrid1.GetSelectedGridObject();
                if (IsUpdateConfirmedDialogResult(orginalDirector, editedDirector ))
                {
                    DataAccess db = new DataAccess();
                    db.UpdateDirector(editedDirector);
                    dataGrid1.RefreshGridWith(editedDirector);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDirector_Event(object sender, EventArgs e)
        {
            try
            {
                Director orginalDirector = (Director)dataGrid1.GetSelectedGridObject();
                if (IsDeleteConfirmedDialogResult(orginalDirector))
                {

                    DataAccess db = new DataAccess();
                    db.DeleteDirector(orginalDirector);
                    dataGrid1.LoadAllDirectorsToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void AddDirector_Event(object sender, EventArgs e)
        {
            try
            {
                Director directorToAdd = directorsUserControl.BuildDirectorFromTextBoxes();
                if (IsAddDataConfirmedDialogResult(directorToAdd))
                {
                    DataAccess db = new DataAccess();
                    db.AddDirector(directorToAdd);
                    dataGrid1.LoadAllDirectorsToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        #endregion

        #region Actor Control Events

        private void SearchActor_Event(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();
                dataGrid1.Actors = db.SearchActors(actorUserControl.BuildActorFromTextBoxes());
                dataGrid1.PopulateGridWithActors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateActor_Event(object sender, EventArgs e)
        {
            try
            {
                Actor editedActor = actorUserControl.BuildActorFromTextBoxes();
                Actor orginalActor = (Actor)dataGrid1.GetSelectedGridObject();
                if (IsUpdateConfirmedDialogResult(orginalActor, editedActor))
                {
                    DataAccess db = new DataAccess();
                    db.UpdateActor(editedActor);
                    dataGrid1.RefreshGridWith(editedActor);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteActor_Event(object sender, EventArgs e)
        {
            try
            {
                Actor orginalActor = (Actor)dataGrid1.GetSelectedGridObject();
                if (IsDeleteConfirmedDialogResult(orginalActor))
                {
                    DataAccess db = new DataAccess();
                   // db.DeleteActor(orginalActor);
                    dataGrid1.LoadAllActorsToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddActor_Event(object sender, EventArgs e)
        {
            try
            {
                Actor actorToAdd = actorUserControl.BuildActorFromTextBoxes();
                if (IsAddDataConfirmedDialogResult(actorToAdd))
                {
                    DataAccess db = new DataAccess();
                    //db.AddActor(actorToAdd);
                    dataGrid1.LoadAllDirectorsToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #region DataGrid Events

        private void SelectedRowChange_Event(object sender, EventArgs e)
        {
            if (editMoviesControl1.Visible == true && 
                editMoviesControl1.GetCurrentUsage()  == (int)MovieControlUsage.EDIT_MOVIE)
            {
                editMoviesControl1.SetSelectedMovie((Movie)dataGrid1.GetSelectedGridObject());
            }
            else if (directorsUserControl.Visible == true && 
                     directorsUserControl.GetCurrentUsage() == (int)ControlUsage.EDIT)
            {
                directorsUserControl.SetSelectedDirector((Director)dataGrid1.GetSelectedGridObject());
            }
            else if(actorUserControl.Visible == true &&
                    actorUserControl.GetCurrentUsage() == (int)ControlUsage.EDIT)
            {
                actorUserControl.SetSelectedActor((Actor)dataGrid1.GetSelectedGridObject());
            }
        }

        #endregion

        #region Confirm Update Add Delete Dialog Boxes

        private bool IsUpdateConfirmedDialogResult(object original, object update)
        {
            DialogResult confirm = MessageBox.Show($"Confirm Update of:\nOriginal: { original.ToString() }\nUpdate: { update.ToString() }",
             "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private bool IsAddDataConfirmedDialogResult(object dataModel)
        {
            DialogResult confirm = MessageBox.Show($"Confirm the addtion of:\n{ dataModel.ToString() }",
             "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private bool IsDeleteConfirmedDialogResult(object dataModel)
        {
            DialogResult confirm = MessageBox.Show($"Confirm deletion of:\n{ dataModel.ToString() }",
                "Confirm 1", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
                return true;
            else
                return false;
        }

        #endregion

        #region The Testing Button
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
        #endregion
    }

}  

