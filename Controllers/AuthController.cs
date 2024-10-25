using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using net_core_example.Commons.Request.Auth;

namespace net_core_example.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : BaseController
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }


        [HttpPost("register")]
        public Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            return null;
        }

        [HttpPost("login")]
        public Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return null;
        }
                
    }
}
