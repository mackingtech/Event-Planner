using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
    internal class Event
    {
        String title, description, startDate, endDate, time;
        
        public Event(String title, String Description, String Date)
        {
            this.title = title;
            this.startDate = Date;
            this.description=Description;
        }

        public String getTitle()
        {
            return this.title;
        }


        public String getDescription()
        {
            return this.description;
        }

        public void setStartDate(String date)
        {
            startDate = date;
        }
        public String getStartDate()
        {
            return this.startDate;
        }
        public void setEndDate(String date) 
        {
            endDate = date;
        }

        public void setTime(String time) 
        {
            this.time=time;

        }
        public String getTime()
        {
            return this.time;
        }

    }  
    }

