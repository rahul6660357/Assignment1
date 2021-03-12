using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.API
{
    [Route("api/account")]
    [ApiController]
    public class AccountAPIController : ControllerBase
    {
        public AccountAPIController()
        {

        }
        [HttpPost]
        [Route("userauthencation")]
        public IActionResult Login([FromForm]string Email, [FromForm]string Password)
        {
            LoginViewModel ll = new LoginViewModel();





            return new ObjectResult(ll);
        }

    }
}
