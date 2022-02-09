using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class Participants
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? SportId { get; set; }
        public NameOfsSports Sport { get; set; }
        public string DateOfBirth { get; set; }
        public byte[] Participant_Picture { get; set; }
    }
}
