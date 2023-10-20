using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class CounterpartyEntity
    {
        public int IdCounterparty { get; set; }
        public double? Amount { get; set; }
        public string? Description { get; set; }

        public int? IdProject { get; set; }
        public ProjectEntity? Project { get; set; }

        public List<ParticipationEntity>? Contributors{ get; set; }
    }
}
