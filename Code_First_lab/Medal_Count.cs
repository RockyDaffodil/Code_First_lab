using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class Medal_Count
    {
        public int Id { get; set; }
        //public int? CountryId { get; set; }
        //[ForeignKey("CountryId")]
        //public Country Country { get; set; }
        public int? ConductingId { get; set; }
        public Conducting Conducting { get; set; }
        public int? FirstPlaceId { get; set; }
        [ForeignKey("FirstPlaceId")]
        public Participants FirstPlace { get; set; }
        public int? SecoundPlaceId { get; set; }
        [ForeignKey("SecoundPlaceId")]
        public Participants SecoundPlace { get; set; }
        public int? ThirdPlaceId { get; set; }
        [ForeignKey("ThirdPlaceId")]
        public Participants ThirdPlace { get; set; }
    }
}
