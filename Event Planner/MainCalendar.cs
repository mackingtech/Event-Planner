using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


namespace Event_Planner
{
    public partial class MainCalendar : Form
    {
        int month, year;
        ArrayList eventCollection=new ArrayList(); //JUST DID A SIMPLE INTERNAL INSTANCE ARRAYLIST ( SHOULD BE SQL FOR FURTHER DEVELOPMENT )
        public static int static_month, static_year;
       
        public MainCalendar()
        {
            InitializeComponent();
            //calendarDesigner();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
            createEventPanel.Hide();
            deletePanel.Hide();
        }
        private void displaDays()
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            // first day of the month
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            populateContainer();
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createEventPanel.Show();
            
            createButton.Hide();

           
        }

        //When you click at a certain date in the month calendar in the create event section it stores it at the eventDate
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            eventDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
        //cancel button reloads the calendar
        private void cancelButton_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            clear();
            createEventPanel.Hide();
            displaDays();
            createButton.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear(); //calls clear method where it basically just clear fields
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear the container
            daycontainer.Controls.Clear();
            //previous month
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            populateContainer();
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Event evnt = new Event(titleTextBox.Text, descriptionTextBox.Text, eventDate.Text);
            String tempTime = timePicker.Text + amPm.Text;
            evnt.setTime(tempTime);
            eventCollection.Add(evnt);
            createButton.Show();
            daycontainer.Controls.Clear();
            displaDays();
            createEventPanel.Hide();
            clear();
            populateDataGrid();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear the container
            daycontainer.Controls.Clear();
            //next month
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            populateContainer();

            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            eventCollection.Remove(titleComparator(deleteTxtBox.Text));
            populateDataGrid();
        }

        private void clear()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            eventDate.ResetText();
            amPm.ResetText();
            timePicker.ResetText();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            if (deletePanel.Visible)
            {
                deletePanel.Hide();
                daycontainer.Controls.Clear();
                populateContainer();
            }
            else
                deletePanel.Show();


        }

        private void deleteCancelButton_Click(object sender, EventArgs e)
        {
            deletePanel.Hide();
            daycontainer.Controls.Clear();
            populateContainer();
        }

        private void populateDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Event item in eventCollection)
            {
                
                String title = item.getTitle();
                String description = item.getDescription();
                String date = item.getStartDate();
                dataGridView1.Rows.Add(title, description, date);
                
            }
            
        }

       private Event titleComparator(String x)
        {
            Event evnt=null;
            foreach (Event item in eventCollection)
            {
                if (x == item.getTitle()) 
                {
                    evnt= item;
                }
            }
            return evnt;
        }

        private void populateContainer()
        {
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                String format = month + "/" + i + "/" + year;//FORMAT VALUE OF THE DATE SO IT CAN BE USED AS STRING COMPARATOR FOR THE LOOP BELOW
                foreach (Event item in eventCollection)
                {

                    String x = item.getStartDate();
                    if (x == format)
                    {
                        ucdays.eventContain(item.getTitle());
                        ucdays.hoverDescription(item.getDescription() + " @ " + item.getTime());
                    }
                }
                daycontainer.Controls.Add(ucdays);
            }
            calendarDesigner(month);
        }
        private void calendarDesigner(int month)
        {
            var BG = this;
            
            var xmas = Event_Planner.Properties.Resources.christmasBetter;
            var thanksgiving = Event_Planner.Properties.Resources.Thanksgiving;
            var holloween = Event_Planner.Properties.Resources.Holloween;
            var spring = Event_Planner.Properties.Resources.spring;
            var summer = Event_Planner.Properties.Resources.summer;
            var winter = Event_Planner.Properties.Resources.winter;
            var fall = Event_Planner.Properties.Resources.fall;


            if (month == 12)
            {
                BG.BackgroundImage = xmas;

            } else if (month == 11)
            {
                BG.BackgroundImage = thanksgiving;

            } else if (month == 10)
            {
                BG.BackgroundImage = holloween;

            } else if (month == 6 | month == 7 | month == 8)
            {
                BG.BackgroundImage = summer;

            } else if (month == 3 | month == 4 | month == 5)
            {
                BG.BackgroundImage = spring;

            } else if (month == 1 | month == 2)
            {
                BG.BackgroundImage = winter;

            } else if (month == 9)
            {
                BG.BackgroundImage = fall;
            }

        }
    }

     
    }
    

