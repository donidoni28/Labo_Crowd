using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class ProjectEntity
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PublishDate { get; set; }

        public int? IdProjectOwner { get; set; }
        public UserEntity? ProjectOwner { get; set; }

        public List<CounterpartyEntity>? Counterparties { get; set; }
        public List<DonationEntity>? Donators { get; set; }
    }
}
