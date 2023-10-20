using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Models
{
    public class ProjectModel
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PublishDate { get; set; }
    }
    public class ProjectAddModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        public double Amount { get; set; }
        
        // if Publish imperativ to set End Date
        //public DateTime? EndDate { get; set; }
        //public DateTime? PublishDate { get; set; }

    }
    public class ProjectUpdateModel
    {
        [Required]
        public int IdProject { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public double Amount { get; set; }
        
    }
    public class ProjectGetModel
    {

        public int IdProject { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime CreatedAt { get; set; }

        // if Publish imperativ to set End Date
        public DateTime? EndDate { get; set; }
        public DateTime? PublishDate { get; set; }
    }
    public class ProjectGetAllModel
    {

        public int IdProject { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

    }

}
