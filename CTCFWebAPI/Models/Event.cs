using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTCFWebAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string sEvent { get; set; }
        public string sPlace { get; set; }
        public string sDescription { get; set; }
        public string sImage { get; set; }
    }
}