using System.ComponentModel.DataAnnotations;

namespace API_Data_CRM.Models.Entity
{
    public class Usuario
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

