using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// First name of the person.
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public String LastName { get; set; }

        /// <summary>
        /// Email address of the person.
        /// </summary>
        public String EmailAddress { get; set; }

        /// <summary>
        /// Cell phone number of the person.
        /// </summary>
        public String CellPhoneNumber { get; set; }
    }
}
