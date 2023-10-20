using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class DonationEntity
    {
        public int? IdUser { get; set; }
        public UserEntity? User { get; set; }

        public int? IdProject { get; set; }
        public ProjectEntity? Project { get; set; }

        public DateTime? DateOfDonation { get; set; }
        public double? Amount { get; set; }


    }
}
