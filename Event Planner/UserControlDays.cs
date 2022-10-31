using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Planner
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public String description;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }
        public void color()
        {
           
        }
        public void eventContain(String title)
        {
            if (String.IsNullOrEmpty(eventContainer.Text))
            eventContainer.Text = title;
            else
                eventContainer2.Text = title;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
  
        }
        public void hoverDescription(String description)
        {
            this.description = description;
        }

        private void eventContainer_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(eventContainer, description);
        }

        private void eventContainer_Click(object sender, EventArgs e)
        {
            

        }
    }
}
