using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeCv.Models.Entity
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Department { get; set; }
        public decimal Gpa { get; set; }
        public string Date { get; set; }
    }
}