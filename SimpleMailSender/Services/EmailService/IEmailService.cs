using SimpleMailSender.Models;

namespace SimpleMailSender.Services.EmailService
{
	public interface IEmailService
	{
		void SendEmail(EmailDto request);	
	}
}
