using System.ComponentModel.DataAnnotations;

namespace BookerApp.Models
{
    public class UserResponeDTO
    {
        public Long Id { get;set;}
        public String Username { get;set;}
        public String Email { get;set;}

    }
}