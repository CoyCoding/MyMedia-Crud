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
        List<Movie> Movies = new List<Movie>();
        bool MovieTabOpening = true;
        bool ActorTabOpening = true;
        bool DirectorTabOpening = true;

        public Dashboard()
        {

            InitializeComponent();
            DataAccessSelect db = new DataAccessSelect();
            Movies = db.GetMovies();
            dataGridView2.DataSource = Movies;


        }

        //private void ShowAllMoviesBtn_Click(object sender, EventArgs e)
        //{
        //    DataAccessSelect db = new DataAccessSelect();
        //    Movies = db.GetMovies();

        //}

        //private void SearchByDirectorBtn_Click(object sender, EventArgs e)
        //{
        //    DataAccessSelect db = new DataAccessSelect();
        //    try
        //    {
        //        Movies = db.GetMovieByDirector(DirFirstNameTextBox.Text, DirLastNameTextBox.Text);
        //        UpdateList();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No Director Entry was made");
        //    }
            
        //}

        private void UpdateList()
        {

        }

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
    }
   
}
