using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Home { get; set; }

        public string StadiumInfo { get; set; }
    }
}