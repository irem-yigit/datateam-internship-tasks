namespace BookerApp.Models
{
    public class User
    {
        [GeneratedType.Identity] 
        public Long Id { get;set;}

        [Required(ErrorMessage = "Username cannot be blank")]
        [StringLength(50, MinimumLength = 2, 
            ErrorMessage = "Username must be between 2 and 50 characters")]
        public String Username { get;set;}
        
        [Required]
        [EmailAddress]
        public String Email { get;set;}

        [Required]
        [MinLength(6)]  
        public String Password { get;set;}

    }
}