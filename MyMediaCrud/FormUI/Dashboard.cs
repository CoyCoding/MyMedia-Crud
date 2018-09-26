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
        private List<Movie> Movies = new List<Movie>();
        private List<Director> Directors = new List<Director>();
        private List<Actor> Actors = new List<Actor>();
        private bool MovieTabOpening = true;
        private bool ActorTabOpening = true;
        private bool DirectorTabOpening = true;
        
        public Dashboard()
        {
           InitializeComponent();
        }

        //private void UpdateList()
        //{
        //    DataAccessSelect db = new DataAccessSelect();
        //    dataGridView2.DataSource = Movies;
        //}

        //private void SearchByActorBtn_Click(object sender, EventArgs e)
        //{
        //    DataAccessSelect db = new DataAccessSelect();
        //    try
        //    {
        //        Movies = db.GetMovieByActor(ActorFirstNameTextBox.Text, ActorLastNameTextBox.Text);
        //        UpdateList();
                
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No Actor Entry was made");
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        { 
            DropDownTimer.Start();
        }

        private void DropDownTimer_Tick_1(object sender, EventArgs e)
        {
            if (!MovieTabOpening)
            {
                MoviePanel.Height -= 11;
                if (MoviePanel.Height <= 0)
                {
                    MoviePanel.Height = 0;
                    MovieTabOpening = true;
                    DropDownTimer.Stop();
                }
            }
            else if (MovieTabOpening)
            {
                MoviePanel.Height += 11;
                if (MoviePanel.Height >= 132)
                {
                    MoviePanel.Height = 132;
                    MovieTabOpening = false;
                    DropDownTimer.Stop();
                }
            }


        }

        private void ActorDropDownBtn_Click(object sender, EventArgs e)
        {
            ActorDropDownTimer.Start();
        }

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
                if (ActorPanel.Height >= 132)
                {
                    ActorPanel.Height = 132;
                    ActorTabOpening = false;
                    ActorDropDownTimer.Stop();
                }
            }
        }

        private void DirectorDropDownBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
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
                if (DirectorPanel.Height >= 132)
                {
                    DirectorPanel.Height = 132;
                    DirectorTabOpening = false;
                    DirectorDropDownTimer.Stop();
                }
            }
        }

        private void AllMoviesBtn_Click(object sender, EventArgs e)
        {
            DropDownTimer.Start();
            dataGridView2.Columns.Clear();
            DataAccessSelect db = new DataAccessSelect();
            Movies = db.GetMovies();
            dataGridView2.DataSource = Movies;
            dataGridView2.Columns.Add(titleDataGridViewTextBoxColumn);
            dataGridView2.Columns.Add(runtimeDataGridViewTextBoxColumn);
            dataGridView2.Columns.Add(yearDataGridViewTextBoxColumn);


        }

        private void SearchByDirector_Search(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Columns.Clear();
                dataGridView2.Columns.AddRange(titleDataGridViewTextBoxColumn, runtimeDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn);
                DataAccessSelect db = new DataAccessSelect();
                Movies = db.GetMovieByDirector(searchByDirectorControl.FirstName(), searchByDirectorControl.LastName());
                dataGridView2.DataSource = Movies;
            }
            catch
            {
                MessageBox.Show("No Director Entry was made");
            }
        }

        private void SearchByActor_Search(object sender, EventArgs e)
        {
            MessageBox.Show("Not ready");
        }

        private void MoviesByActorBtn_Click(object sender, EventArgs e)
        {
            DropDownTimer.Start();
            searchByActorControl.BringToFront();
        }

        private void MoviesByDirector_Click(object sender, EventArgs e)
        {
            DropDownTimer.Start();
            searchByDirectorControl.BringToFront();
        }

        private void AllDirectorsBtn_Click(object sender, EventArgs e)
        {
            DirectorDropDownTimer.Start();
            searchByDirectorControl.BringToFront();
            DataAccessSelect db = new DataAccessSelect();
            dataGridView2.Columns.Clear();
            Directors = db.GetDirectors();
            dataGridView2.DataSource = Directors;
            dataGridView2.Columns.Add(firstNameDataGridViewTextBoxColumn);
            dataGridView2.Columns.Add(lastNameDataGridViewTextBoxColumn);
        }

    }
   
}
