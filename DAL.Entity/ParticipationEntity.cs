using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class ParticipationEntity
    {
        public int? IdUser { get; set; }
        public UserEntity? User { get; set; }

        public int? IdCounterparty { get; set; }
        public CounterpartyEntity? CounterParty { get; set; }

        public DateTime DateOfParticipation { get; set; }
    }
}
