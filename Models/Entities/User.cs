using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestLoan.Models.Entities;

[PrimaryKey("Id")]
[Index("Email",IsUnique = true)]
[Index("BVN", IsUnique = true)]
public class User
{
    
    public int Id { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    [Range(18, 120)]
    public int Age { get; set; }
    [StringLength(80)]
    public string Email { get; set; }
    [StringLength(20)]
    public string BVN { get; set; }
    [StringLength(100)]
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    [StringLength(25)]
    public string Password { get; set; }
    
    
}