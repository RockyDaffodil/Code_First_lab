using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class City
    {
        public int Id { get; set; }
        public string NameCity { get; set; }
       // public ICollection<Country> Countries { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public City()
        {
           // Countries = new List<Country>();
        }
    }
}
