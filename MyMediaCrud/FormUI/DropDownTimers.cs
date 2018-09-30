using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FormUI
{
    public class DropDownTimers
    {
        static System.Timers.Timer aTimer = new System.Timers.Timer();

        public void MovieDropDown(Panel panel)
        {           
            aTimer.Elapsed += (source, e) => OnTimedEvent(source, e, panel);
            aTimer.Interval = 1;
            aTimer.Enabled = true;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private static void OnTimedEvent(object source, ElapsedEventArgs e, Panel panel)
        {

            
            //panel.Height += 20;
            //if (!MovieTabOpening)
            //{
            //    panel.Height -= 11;
            //    if (panel.Height <= 0)
            //    {
            //        panel.Height = 0;
            //        MovieTabOpening = true;
            //        aTimer.Stop();
            //    }
            //}
            //else if (MovieTabOpening)
            //{
            //    MoviePanel.Height += 11;
            //    if (MoviePanel.Height >= 132)
            //    {
            //        panel.Height = 132;
            //        MovieTabOpening = false;
            //        DropDownTimer.Stop();
            //    }
            //}
        }
            //if (panel.Height >= 132)
            //{
            //    panel.Height = 132;
            //   //MovieTabOpening = false;
            //   // DropDownTimer.Stop();
            //}
        }

       
       
    
}
