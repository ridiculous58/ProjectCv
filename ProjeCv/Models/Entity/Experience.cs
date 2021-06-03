using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeCv.Models.Entity
{
    public class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Date { get; set; }
        public string Detail { get; set; }
    }
}