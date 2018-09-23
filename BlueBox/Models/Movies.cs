using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueBox.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Movies> MovieList { get; set; }
    }
}