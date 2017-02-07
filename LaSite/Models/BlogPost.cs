using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaSite.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string Photo { get; set; }
        public string Place { get; set; }
        public string PhotoDescription { get; set; }
    }
}