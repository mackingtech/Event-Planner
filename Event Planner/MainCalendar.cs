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
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
            createEventPanel.Hide();
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

            DateTime startofthemonth = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1;i<= days;i++)
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
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            
            DateTime startofthemonth = new DateTime(year, month, 1);
            // days of the month
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
                String format = month + "/" + i + "/" + year;
                foreach (Event item in eventCollection) 
                {
                    
                    String x = item.getStartDate();
                    if (x == format)
                    {
                        ucdays.eventContain(item.getTitle());
                        ucdays.hoverDescription(item.getDescription()+ " @ " + item.getTime());
                    }
                }
                    
                daycontainer.Controls.Add(ucdays);
            }
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
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear the container
            daycontainer.Controls.Clear();
            //next month
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            // days of the month
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
                String format = month + "/" + i + "/" + year; //FORMAT VALUE OF THE DATE SO IT CAN BE USED AS STRING COMPARATOR FOR THE LOOP BELOW
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

           
        }
        private void clear()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            eventDate.ResetText();
            amPm.ResetText();
            timePicker.ResetText();
        }
    }
    }

