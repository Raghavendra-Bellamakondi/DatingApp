using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating_API.Data;
using Dating_API.DataEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private  DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;

        }
        [HttpGet]
       public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){

           return  await this._context.Users.ToListAsync();

           
       }
       [HttpGet]
       [Route("{id}")]
        public ActionResult<AppUser> GetUser(int id){

           return this._context.Users.Find(id);

           
       }


    }

}