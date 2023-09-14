using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Net.EF.MVC.Models
{
    public class RickAndMortyView
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public RickLocation location { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public class RickLocation
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}