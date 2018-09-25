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
    public partial class SearchByDirectorForm : UserControl
    {
        public event EventHandler StatusUpdated;

        public SearchByDirectorForm()
        {
            InitializeComponent();
        }

        private void FunctionThatRaisesEvent()
        {
            //Null check makes sure the main page is attached to the event
            
        }

        private void FindByDirBtn_Click(object sender, EventArgs e)
        {
            if (this.StatusUpdated != null)
                this.StatusUpdated(this, new EventArgs());
        }
     
    }
    
}
