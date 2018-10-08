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
    public partial class DirectorsUserControl : UserControl
    {
        public event EventHandler SearchDirector_Event;
        public event EventHandler UpdateDirector_Event;
        public event EventHandler AddDirector_Event;
        public event EventHandler DeleteDirector_Event;
        private Director selectedDirector;
        private int CurrentUsage;

        public DirectorsUserControl()
        {
            InitializeComponent();
        }

        #region New Director From Text Boxes

        private string GetFirstName()
        {
            
            return FirstNameTextBox.Text;
        }

        private string GetLastName()
        {
           
            return LastNameTextBox.Text;
        }

        public Director BuildDirectorFromTextBoxes()
        {
            Director searchableDirector;
            if (CurrentUsage == (int)DirectorControlUsage.SEARCH_DIR || 
                CurrentUsage == (int)DirectorControlUsage.ADD_DIR)
            {
                searchableDirector = new Director
                {
                    FirstName = GetFirstName(),
                    LastName = GetLastName()
                };
            }
            else 
            {
                searchableDirector = new Director
                {
                    id = selectedDirector.id,
                    FirstName = GetFirstName(),
                    LastName = GetLastName()
                };
            }
            return searchableDirector;
        }

        #endregion

        #region Buttons

        private void SearchDirectorBtn_Click(object sender, EventArgs e)
        {
            if(SearchDirector_Event != null)
            {
                SearchDirector_Event(this, new EventArgs());
            }
        }

        private void UpdateDirectorBtn_Click(object sender, EventArgs e)
        {
            if (UpdateDirector_Event != null)
            {
                UpdateDirector_Event(this, new EventArgs());
            }
        }

        private void AddDirectorBtn_Click(object sender, EventArgs e)
        {
            if(AddDirector_Event != null)
            {
                AddDirector_Event(this, new EventArgs());
            }
        }

        private void DeleteDirectorBtn_Click(object sender, EventArgs e)
        {
            if (DeleteDirector_Event != null)
            {
                DeleteDirector_Event(this, new EventArgs());
            }
        }

        #endregion

        public void SetSelectedDirector(Director director)
        {
            selectedDirector = director;
            SetTextBoxes(director);
        }

        public void SetTextBoxes(Director director)
        {
            if (director != null)
            {
                FirstNameTextBox.Text = director.FirstName;
                LastNameTextBox.Text = director.LastName;
            }
            else
            {
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
            }
        }


        #region SetForm Add/Edit/Search 

        public void SetControlAsAdd()
        {
            if (CurrentUsage != (int)DirectorControlUsage.ADD_DIR)
            {
                CurrentUsage = (int)DirectorControlUsage.ADD_DIR;
                SearchActorDirlabel.Text = "Add Director:";
                AddDirectorBtn.Visible = true;
                UpdateDirectorBtn.Visible = false;
                DeleteDirectorBtn.Visible = false;
                SearchDirectorBtn.Visible = false;
            }
        }

        public void SetControlAsEdit()
        {
            if (CurrentUsage != (int)DirectorControlUsage.EDIT_DIR)
            {
                CurrentUsage = (int)DirectorControlUsage.EDIT_DIR;
                SearchActorDirlabel.Text = "Edit Director:";
                AddDirectorBtn.Visible = false;
                UpdateDirectorBtn.Visible = true;
                DeleteDirectorBtn.Visible = true;
                SearchDirectorBtn.Visible = false;
            }
        }

        public void SetControlAsSearch()
        {
            if(CurrentUsage != (int)DirectorControlUsage.SEARCH_DIR)
            {
                CurrentUsage = (int)DirectorControlUsage.SEARCH_DIR;
                SearchActorDirlabel.Text = "Search Director:";
                AddDirectorBtn.Visible    = false;
                UpdateDirectorBtn.Visible = false;
                DeleteDirectorBtn.Visible = false;
                SearchDirectorBtn.Visible = true;
            }
        }

        public int GetCurrentUsage()
        {
            return CurrentUsage;
        }
        #endregion
    }
}
