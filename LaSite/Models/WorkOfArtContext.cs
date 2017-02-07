using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace LaSite.Models
{
    public class WorkOfArtContext : DbContext
    {
        public DbSet<WorkOfArt> WorkOfArts { get; set; }
    }
}