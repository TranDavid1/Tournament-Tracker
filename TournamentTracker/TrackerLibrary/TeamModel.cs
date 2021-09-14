using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        // holds data for List of Person
        // by default initalize TeamMembers as empty list
        public List<Person> TeamMembers { get; set; } = new List<Person>();

        // holds data for String TeamName
        public String TeamName { get; set; }

    }
}
