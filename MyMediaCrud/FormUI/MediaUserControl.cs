using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public abstract class MediaUserControl : UserControl
    {
        //private int CurrentUsage;
        //private Button DeleteBtn;
        //private Button UpdateBtn;
        //private Button AddBtn;
        //private Button SearchBtn;
        //private Label HeaderLabel;

        //public void SetControlAsAdd()
        //{
        //    if (CurrentUsage != (int)ControlUsage.ADD)
        //    {
        //        CurrentUsage = (int)ControlUsage.ADD;
        //        HeaderLabel.Text = $"Add {HeaderLabel.Text}:";
        //        AddBtn.Visible = true;
        //        UpdateBtn.Visible = false;
        //        DeleteBtn.Visible = false;
        //        SearchBtn.Visible = false;
        //    }
        //}

        //public void SetControlAsEdit()
        //{
        //    if (CurrentUsage != (int)ControlUsage.EDIT)
        //    {
        //        CurrentUsage = (int)ControlUsage.EDIT;
        //        HeaderLabel.Text = $"Edit {HeaderLabel.Text}:";
        //        AddBtn.Visible = false;
        //        UpdateBtn.Visible = true;
        //        DeleteBtn.Visible = true;
        //        SearchBtn.Visible = false;
        //    }
        //}

        //public void SetControlAsSearch()
        //{
        //    if (CurrentUsage != (int)ControlUsage.SEARCH)
        //    {
        //        CurrentUsage = (int)ControlUsage.SEARCH;
        //        HeaderLabel.Text = $"Search for {HeaderLabel.Text}:";
        //        AddBtn.Visible = false;
        //        UpdateBtn.Visible = false;
        //        DeleteBtn.Visible = false;
        //        SearchBtn.Visible = true;
        //    }
        //}

        //public int GetCurrentUsage()
        //{
        //    return CurrentUsage;
        //}

    }
}
