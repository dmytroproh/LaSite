using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaSite.Models
{
    public class WorkOfArt
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string Picture { get; set; }
    }
}