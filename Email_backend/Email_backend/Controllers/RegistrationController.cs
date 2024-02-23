using Email_backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IEmail _emailService;

        public RegistrationController(IConfiguration config,IEmail emailService) 
        {
            _config = config;
            _emailService = emailService;
        }
        [HttpPost("CreateUser")]
        
        
        public IActionResult Create([FromBody] Registration request)
        {
            var name = request.to_name;
            var mail = request.to_email;
            EmailDto email = new EmailDto
            {
                to_email = request.to_email,
                Subject ="Registration Successfull",
                Body = "Dear " + name + 
                "<p> Welcome to  Ashish Tech! We're excited to have you join us. </p> " +
                "<p>Here is your registration email: </p> " + mail +
                " <p>Your account is all set up.</p>" +
                " <p>Best Regards</p>" + 
                "<p>Ashish Tech pvt ltd</p>"
            };
            
            _emailService.SendEmail(email);
            return Ok();
        }
    }
}
