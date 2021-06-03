using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjeCv.Models.Entity;
namespace ProjeCv.Models.Model
{
    public class Model
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<Award> Awards { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Interest> Interests { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}