using Email_backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email_backend.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IEmail _emailService;

        public ResetPasswordController(IConfiguration config, IEmail emailService) 
        {
            _config = config;
            _emailService = emailService;
        }
        [HttpPost("reset_password")]
        public IActionResult Reset([FromBody] Reset_Password request)
        {
            
            EmailDto email = new EmailDto
            {
                to_email = request.to_email,
                Subject = "Password Reset successfully",
                Body = "Thank-you " + 
                "<p>Your Password has been successfull changed</p>" +
                " <p>Best Regards</p>" +
                "<p>Ashish Tech pvt ltd</p>"
            };

            _emailService.SendEmail(email);
            return Ok();
        }
    }
}
