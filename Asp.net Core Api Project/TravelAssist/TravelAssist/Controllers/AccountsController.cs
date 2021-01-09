using ManagementSoftware.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelAssist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        // GET: api/<AccountsController>

        public AccountsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Accounts/Register
        [HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            var user = new IdentityUser { UserName = model.UserName, Email = model.Email };
            

            try
            {
                var result = await userManager.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        // POST api/Accounts/Login
        //[HttpPost]
        //[Route("Login")]
        //public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        //{
            
        //    var result = await signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password,
        //        loginViewModel.RememberMe, false);

        //    if (result.Succeeded)
        //    {
        //        return Ok(result);
        //    }
            
        //}


            // PUT api/<AccountsController>/5
            [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
