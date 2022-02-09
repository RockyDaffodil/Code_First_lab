using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class Country
    {
        public int Id { get; set; }
        public string NameCountry { get; set; }
        
        public ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
    }
}
