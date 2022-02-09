using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class Conducting
    {
        public int Id { get; set; }
        public string ConductingOlympicName { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public int? Summer_Winter_OlympId { get; set; }
        [ForeignKey("Summer_Winter_OlympId")]
        public Summer_Winter_Olymp Summer_Winter_Olymp { get; set; }
        public string DateStart { get; set; }
        public int? SportId { get; set; }
        [ForeignKey("SportId")]
        public NameOfsSports NameOfsSports { get; set; }

    }
}
