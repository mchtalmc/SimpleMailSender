using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace SimpleMailSender.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase
	{
		private readonly IEmailService _emailService;
		[HttpPost("SendEmail")]
		public IActionResult SendEmail(EmailDto request)
		{
			#region Ameleus
			//var email = new MimeMessage();
			//email.From.Add(MailboxAddress.Parse("lukas.ebert44@ethereal.email"));
			//email.To.Add(MailboxAddress.Parse("lukas.ebert44@ethereal.email"));
			//email.Subject = "Test Email Subject";
			//email.Body= new TextPart(TextFormat.Html) { Text= body };

			//using var smtp = new SmtpClient();
			//smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
			//smtp.Authenticate("lukas.ebert44@ethereal.email", "EVhYAFFR6GDWqR7VHY");
			//smtp.Send(email);
			//smtp.Disconnect(true);
			#endregion



			#region Profesyonel Yontem
 
			_emailService.SendEmail(request);
			return Ok();

			#endregion


			
			
		}
	}
}
