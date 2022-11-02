using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
    internal class eventCollection
    {
        String description, title, date;
       
        public eventCollection(Event evnt)
        {
            this.description=evnt.getDescription();
            this.title=evnt.getTitle();
            this.date = evnt.getStartDate();
            
            
        }
        
    }
}
