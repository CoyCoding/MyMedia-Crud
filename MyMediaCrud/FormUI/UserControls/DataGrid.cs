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
            if (dataGridView.DataSource == null)
            {
                PopulateGrid();
            }
            else
            {
                if (dataGridView.DataSource.GetType().ToString() == Movies.ToString())
                {
                    dataGridView.DataSource = Movies;
                }
                else
                {
                    PopulateGrid();
                }
            }  
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
            if (dataGridView.DataSource == null)
            {
                AddDirectorColumns();
            }
            else
            {
                if (dataGridView.DataSource.GetType().ToString() == Directors.ToString())
                {
                    dataGridView.DataSource = Directors;
                }
                else
                {
                    AddDirectorColumns();
                }
            }
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

        public DataGridViewRow GetSelectedRow()
        {
            return dataGridView.SelectedRows[0];
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedRowChange_Event != null && dataGridView.SelectedRows.Count == 1)
            {

                SelectedRowChange_Event(this, new EventArgs());
            }

        }
    }
}
