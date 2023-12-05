using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIuniversidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorizaController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AutorizaController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
            public ActionResult<string> Get(){
                return "AutorizaController :: Acessado em " + DateTime.Now.ToLongDateString();
            }

    }
}