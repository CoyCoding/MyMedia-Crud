using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class VisablityController
    {
        private UserControl ActiveControl;

        public UserControl ActiveUserControl {

            get { return ActiveControl; }

            set
            {
                if (ActiveControl != value)
                {
                    if (ActiveControl == null)
                    {
                        SetNewValueVisable(value);
                    }
                    else
                    {
                        SetOldValueNotVisable();
                        SetNewValueVisable(value);
                    }
                }
            }
        }

        private void SetNewValueVisable(UserControl userControl)
        {
                ActiveControl = userControl;
                ActiveControl.Visible = true;
        }

        private void SetOldValueNotVisable()
        {
            ActiveControl.Visible = false;
        }
    }
}
