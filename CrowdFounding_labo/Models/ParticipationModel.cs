using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFounding_labo.Models
{
    public class ParticipationModel
    {
        public int? IdUser { get; set; }
        public int? IdCounterparty { get; set; }
        public DateTime DateOfParticipation { get; set; }
    }
    public class ParticipationAddModel
    {
        public int? IdUser { get; set; }
        public int? IdCounterparty { get; set; }
        public DateTime DateOfParticipation { get; set; }
    }
    public class ParticipationUpdateModel
    {
        public int? IdUser { get; set; }
        public int? IdCounterparty { get; set; }
        public DateTime DateOfParticipation { get; set; }
    }
    public class ParticipationGetModel
    {

        public int? IdUser { get; set; }
        public int? IdCounterparty { get; set; }
        public DateTime DateOfParticipation { get; set; }
    }
    public class ParticipationGetAllModel
    {
        public int? IdUser { get; set; }
        public int? IdCounterparty { get; set; }
        public DateTime DateOfParticipation { get; set; }
    }


}
