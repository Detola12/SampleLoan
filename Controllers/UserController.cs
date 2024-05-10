using Microsoft.AspNetCore.Mvc;
using TestLoan.Data;
using TestLoan.Models;
using TestLoan.Models.Entities;

namespace TestLoan.Controllers;

public class UserController : Controller
{
    private readonly LoanContext _context;
    public UserController(LoanContext context)
    {
        _context = context;
    }

    public IActionResult Success()
    {
        return View();
    }
    
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(UserViewModel users)
    {
        var user = new User()
        {
            FirstName = users.FirstName,
            LastName = users.LastName,
            Age = users.Age,
            Address = users.Address,
            BVN = users.BVN,
            Email = users.Email,
            Password = users.Password,
            CreatedAt = DateTime.Now,
            ModifiedAt = DateTime.Now
        };
        
        

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        var tempuser = _context.Users.FirstOrDefault(x => x.Email == user.Email);
        var tempId = tempuser.Id;
        
        return RedirectToAction("Index", "Loan", new{Id = tempId});
    }
}