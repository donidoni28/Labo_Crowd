using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DAL.Repository.Models
{
    
    public  class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
    }
    public  class UserAddModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        
    }
    public class UserUpdateModel 
    {
        
        [Required]
        public new int IdUser { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
    public class UserGetModel 
    {
        public int IdUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
    public class UserGetAllModel
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }
    }

}