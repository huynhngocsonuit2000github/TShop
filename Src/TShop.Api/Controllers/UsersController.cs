using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TShop.Domain.DataAccess;

namespace TShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly TShopDbContext context;

    public UsersController(TShopDbContext _context)
    {
        context = _context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var data = context.Users.ToList();
        return Ok(data);
    }
}
