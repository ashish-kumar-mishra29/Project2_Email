

using Email_backend.Models;

namespace Email_backend.Services.EmailService
{
    public interface IEmail
    {
        void SendEmail(EmailDto request);
    }
}
