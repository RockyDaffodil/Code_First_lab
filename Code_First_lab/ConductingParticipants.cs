using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class ConductingParticipants
    {
        public int Id { get; set; }
        public int? ParticipantsId { get; set; }
        public Participants Participants { get; set; }
        public int? ConductingId { get; set; }
        public Conducting Conducting { get; set; }
    }
}
