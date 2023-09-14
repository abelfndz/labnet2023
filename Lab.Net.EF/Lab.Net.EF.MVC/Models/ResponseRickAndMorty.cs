using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Net.EF.MVC.Models
{
    public class ResponseRickAndMorty
    {
        public RickApiInfo info { get; set; }
        public List<RickAndMortyView> results { get; set; }
    }
    public class RickApiInfo
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}