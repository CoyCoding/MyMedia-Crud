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
    public partial class ActorUserControl : UserControl
    {
        public event EventHandler SearchActor_Event;
        public event EventHandler UpdateActor_Event;
        public event EventHandler AddActor_Event;
        public event EventHandler DeleteActor_Event;
        private Actor selectedActor;
        private int CurrentUsage;

        public ActorUserControl()
        {
            InitializeComponent();
        }

        #region Set Form Add/Search/Edit

        public void SetControlAsAdd()
        {
            if (CurrentUsage != (int)ControlUsage.ADD)
            {
                CurrentUsage = (int)ControlUsage.ADD;
                HeaderLabel.Text = "Add Actor:";
                AddBtn.Visible = true;
                UpdateBtn.Visible = false;
                DeleteBtn.Visible = false;
                SearchBtn.Visible = false;
            }
        }

        public void SetControlAsEdit()
        {
            if (CurrentUsage != (int)ControlUsage.EDIT)
            {
                CurrentUsage = (int)ControlUsage.EDIT;
                HeaderLabel.Text = "Edit Actor:";
                AddBtn.Visible = false;
                UpdateBtn.Visible = true;
                DeleteBtn.Visible = true;
                SearchBtn.Visible = false;
            }
        }

        public void SetControlAsSearch()
        {
            if (CurrentUsage != (int)ControlUsage.SEARCH)
            {
                CurrentUsage = (int)ControlUsage.SEARCH;
                HeaderLabel.Text = "Search Actor:";
                AddBtn.Visible = false;
                UpdateBtn.Visible = false;
                DeleteBtn.Visible = false;
                SearchBtn.Visible = true;
            }
        }

        public int GetCurrentUsage()
        {
            return CurrentUsage;
        }

        #endregion

        #region Radio Buttons

        private void MaleRadioButton_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                MaleRadioButton.Checked = false;
            }
            else
            {
                MaleRadioButton.Checked = true;
                FemaleRadioButton.Checked = false;
            }
        }

        private void FemaleRadioButton_Click(object sender, EventArgs e)
        {
            if (FemaleRadioButton.Checked)
            {
                FemaleRadioButton.Checked = false;
            }
            else
            {
                FemaleRadioButton.Checked = true;
                MaleRadioButton.Checked = false;
            }
        }

        private void SetGenderMale()
        {
            MaleRadioButton.Checked = true;
            FemaleRadioButton.Checked = false;
        } 

        private void SetGenderFemale()
        {
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = true;
        }

        private void SetGenderUnknown()
        {
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
        }

        #endregion

        #region Actor from TextBoxes

        private string GetFirstName()
        {

            return FirstNameTextBox.Text;
        }

        private string GetLastName()
        {

            return LastNameTextBox.Text;
        }

        private char? GetGender()
        {
            if (MaleRadioButton.Checked)
            {
                return 'M';
            }else if (FemaleRadioButton.Checked)
            {
                return 'F';
            }
            else

            {
                return null;
            }
        }

        public Actor BuildActorFromTextBoxes()
        {
            Actor searchableActor;
            if (CurrentUsage == (int)ControlUsage.SEARCH ||
                CurrentUsage == (int)ControlUsage.ADD)
            {
                searchableActor = new Actor
                {
                    FirstName = GetFirstName(),
                    LastName = GetLastName(),
                    Gender = GetGender()
                };
            }
            else
            {
                searchableActor = new Actor
                {
                    id = selectedActor.id,
                    FirstName = GetFirstName(),
                    LastName = GetLastName(),
                    Gender = GetGender()
                };
            }
            return searchableActor;
        }

        #endregion

        #region Selected Actor To TextBox Display

        public void SetSelectedActor(Actor actor)
        {
            selectedActor = actor;
            SetTextBoxes(selectedActor);
        }

        public void SetTextBoxes(Actor actor)
        {
            if (actor != null)
            {
                FirstNameTextBox.Text = actor.FirstName;
                LastNameTextBox.Text = actor.LastName;

                if ( actor.Gender == 'M' )
                {
                    SetGenderMale();
                }
                else if ( actor.Gender == 'F' )
                {
                    SetGenderFemale();
                }
                else
                {
                    SetGenderUnknown();
                }

            }
            else
            {
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                SetGenderUnknown();
            }
        }

        #endregion

        #region Buttons

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(SearchActor_Event != null)
            {
                SearchActor_Event(this, new EventArgs());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(UpdateActor_Event != null)
            {
                UpdateActor_Event(this, new EventArgs());
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(AddActor_Event != null)
            {
                AddActor_Event(this, new EventArgs());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(DeleteActor_Event != null)
            {
                DeleteActor_Event(this, new EventArgs());
            }
        }

        #endregion
    }

}
