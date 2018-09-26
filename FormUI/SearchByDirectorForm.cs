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
        public event EventHandler DirectorSearch;

        public SearchByDirectorForm()
        {
            InitializeComponent();

        }


        private void FindByDirBtn_Click(object sender, EventArgs e)
        {
            if (DirectorSearch != null)
            {
                DirectorSearch(this, new EventArgs());
            }
        }

        public string FirstName()
        {
            return DirFirstNameTextBox.Text;
        }

        public string LastName()
        {
            return DirLastNameTextBox.Text;
        }
    }
    
}
