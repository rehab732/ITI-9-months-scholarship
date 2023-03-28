using Day3.DTO;
using Day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        public AccountController(UserManager<ApplicationUser> usermanager)
        {
            this.userManager = usermanager;

        }
        //create account for new user "post"
        [HttpPost("register")]
        public async Task<IActionResult> Regestration(RegisterUserDTO user)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser userr=new ApplicationUser();
                userr.UserName= user.UserName;
                userr.Email= user.Email;
             IdentityResult res=  await userManager.CreateAsync(userr, user.Password);
                if(res.Succeeded)
                {
                    return Ok("Success");
                }
                return BadRequest(res.Errors.FirstOrDefault());
            }
           
                return BadRequest(ModelState);
            

        }

    }
}
