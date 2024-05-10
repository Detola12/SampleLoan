using System.ComponentModel.DataAnnotations;

namespace TestLoan.Models;

public class UserViewModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [Range(18, 120)]
    public int Age { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string BVN { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string Password { get; set; }
}