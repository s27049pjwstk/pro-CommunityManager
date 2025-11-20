using CommunityManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunityManager.Controllers;

[Route("[controller]")]
public class DoWorkController(SampleDb db) : Controller {
    // GET
    [HttpGet]
    [Route("")]
    public IActionResult Index() {
        return Ok(db.WorkOrders.ToList()); //todo add limit?
    }
    
}