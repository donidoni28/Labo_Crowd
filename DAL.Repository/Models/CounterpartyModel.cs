using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Models
{
    
    public class CounterpartyModel
    {
        public int IdCounterparty { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
    public class CounterpartyAddModel
    {
        public int IdCounterparty { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

    }
    public class CounterpartyUpdateModel
    {
        public int IdCounterparty { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
    public class CounterpartyGetModel
    {
        public int IdCounterparty { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
    }
    public class CounterpartyGetAllModel
    {
        public int IdCounterparty { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
    }
    
}
