using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PackIt.Models
{
    public class PackingList
    {
        public int ID { get; set; }
        public string ListName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpated { get; set; }
        public string CreatedBy { get; set; }
        public string ListDescription { get; set; }
        public string Season { get; set; }
    }
}