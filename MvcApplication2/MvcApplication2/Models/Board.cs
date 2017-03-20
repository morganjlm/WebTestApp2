using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Board
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Access { get; set; }
        public List<string> Visible { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool Approved { get; set; }
        public bool Audit { get; set; }
        public DateTime AuditDate { get; set; }

    }
}