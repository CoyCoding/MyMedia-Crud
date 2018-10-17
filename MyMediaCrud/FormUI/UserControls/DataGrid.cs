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
    public partial class DataGrid : UserControl
    {
        public List<Movie> Movies { get; set; }
        public List<Director> Directors { get; set; }
        public List<Actor> Actors { get; set; }

        public event EventHandler SelectedRowChange_Event;

        public DataGrid()
        {
            InitializeComponent();
        }

        #region Populate Movie Grid Logic

        public void LoadAllMoviesToGrid()
        {
            DataAccess db = new DataAccess();
            Movies = db.GetAllMovies();
            PopulateGridWithMovies();
        }

        public void PopulateGridWithMovies()
        {
            PopulateGrid();

        }

        private void PopulateGrid()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = Movies;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(idDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(titleDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(directorDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(runtimeDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(yearDataGridViewTextBoxColumn);
            idDataGridViewTextBoxColumn.Visible = false;
        }

        #endregion

        #region Populate Director Grid Logic

        public void LoadAllDirectorsToGrid()
        {
            DataAccess db = new DataAccess();
            Directors = db.GetDirectors();
            PopulateGridWithDirectors();
        }

        public void PopulateGridWithDirectors()
        {
            AddDirectorColumns();

        }

        private void AddDirectorColumns()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = Directors;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(idDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(firstNameDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(lastNameDataGridViewTextBoxColumn);
            idDataGridViewTextBoxColumn.Visible = false;
        }

        #endregion

        #region Populate Actor Grid Logic

        public void LoadAllActorsToGrid()
        {
            DataAccess db = new DataAccess();
            Actors = db.GetActors();
            PopulateGridWithActors();
        }

        public void PopulateGridWithActors()
        {
            AddActorColumns();

        }

        private void AddActorColumns()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = Actors;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(idDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(firstNameDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(lastNameDataGridViewTextBoxColumn);
            dataGridView.Columns.Add(genderDataGridViewTextBoxColumn);
            idDataGridViewTextBoxColumn.Visible = false;
        }
        #endregion

        #region Refresh Grid Overloads

        public void RefreshGridWith(Movie editedMovie)
        {
            foreach (Movie movie in Movies)
            {
                if (movie.id == editedMovie.id)
                {
                    if (editedMovie.Title != null) { movie.Title = editedMovie.Title; }
                    if (editedMovie.Runtime != null) { movie.Runtime = editedMovie.Runtime; }
                    if (editedMovie.Year != null) { movie.Year = editedMovie.Year; }
                    if (editedMovie.Director != null) { movie.Director = editedMovie.Director; }
                    dataGridView.Refresh();
                    break;
                }
            }
        }

        public void RefreshGridWith(Director editedDirector)
        {
            foreach (Director director in Directors)
            {
                if (director.id == editedDirector.id)
                {
                    if (editedDirector.FirstName != null)
                    {
                        director.FirstName = editedDirector.FirstName;
                    }
                    if (editedDirector.LastName != null)
                    {
                        director.LastName = editedDirector.LastName;
                    }
                    dataGridView.Refresh();
                    break;
                }
            }
        }

        public void RefreshGridWith(Actor editedActor)
        {
            foreach (Actor actor in Actors)
            {
                if (actor.id == editedActor.id)
                {
                    if (editedActor.FirstName != null)
                    {
                        actor.FirstName = editedActor.FirstName;
                    }
                    if (editedActor.LastName != null)
                    {
                        actor.LastName = editedActor.LastName;
                    }
                    if (editedActor.Gender != null)
                    {
                        actor.Gender = editedActor.Gender;
                    }
                    dataGridView.Refresh();
                    break;
                }
            }
        }

        #endregion

        #region Row Selection Logic/Event

        private DataGridViewRow GetSelectedRow()
        {
            return dataGridView.SelectedRows[0];
        }

        public object GetSelectedGridObject()
        {
            return GetSelectedRow().DataBoundItem;
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedRowChange_Event != null && dataGridView.SelectedRows.Count == 1)
            {
                SelectedRowChange_Event(this, new EventArgs());
            }

        }

        #endregion
    }
}
