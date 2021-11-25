using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Models
{
    public class Team
    {

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }



        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }



        /// <summary>Gets or sets the home.</summary>
        /// <value>The home.</value>
        public string Home { get; set; }



        /// <summary>Gets or sets the stadium information.</summary>
        /// <value>The stadium information.</value>
        public string StadiumInfo { get; set; }
    }
}
