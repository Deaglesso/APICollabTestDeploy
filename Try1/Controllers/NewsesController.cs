using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Try1.Data;

namespace Try1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NewsesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public NewsesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllNewses()
        {
            return Ok(dbContext.Newses.ToList());
        }
    }
}
