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
    }
}
