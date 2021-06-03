using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjeCv.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Award> Awards { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}