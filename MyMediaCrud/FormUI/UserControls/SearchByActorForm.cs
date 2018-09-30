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
    public partial class SearchByActorForm : UserControl
    {
        public event EventHandler ActorSearch;

        public SearchByActorForm()
        {
            InitializeComponent();
        }

        private void FindByActorBtn_Click(object sender, EventArgs e)
        {
            if (ActorSearch != null)
            {
                ActorSearch(this, new EventArgs());
            }
        }
    }
}
