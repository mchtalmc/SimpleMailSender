
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace SimpleMailSender.Services.EmailService
{
	public class EmailService : IEmailService
	{
		//private readonly IConfiguration _configuration;
		private readonly IOptions<EmailDetails> _emailOptions;

		public EmailService(/*IConfiguration configuration,*/ IOptions<EmailDetails> emailOptions)
		{
			//_configuration = configuration;
			_emailOptions = emailOptions;
		}


		#region Ameleus Yontem
		//public void SendEmail(EmailDto request)
		//{
		//	var email = new MimeMessage();
		//	email.From.Add(MailboxAddress.Parse("lukas.ebert44@ethereal.email"));
		//	email.To.Add(MailboxAddress.Parse(request.To));
		//	email.Subject = request.Subject;
		//	email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

		//	using var smtp = new SmtpClient();
		//	smtp.Connect(_configuration.GetSection("EmailHost").Value  , 587, MailKit.Security.SecureSocketOptions.StartTls);
		//	smtp.Authenticate(_configuration.GetSection("EmailUsername").Value, _configuration.GetSection("EmailPassword").Value);
		//	smtp.Send(email);
		//	smtp.Disconnect(true);
		//}
		#endregion

		#region Profesyonel Yontem
		public void SendEmail(EmailDto request)
		{
			var email = new MimeMessage();
			email.From.Add(MailboxAddress.Parse("lukas.ebert44@ethereal.email"));
			email.To.Add(MailboxAddress.Parse(request.To));
			email.Subject = request.Subject;
			email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

			using var smtp = new SmtpClient();
			smtp.Connect(_emailOptions.Value.EmailHost   , 587, MailKit.Security.SecureSocketOptions.StartTls);
			smtp.Authenticate(_emailOptions.Value.EmailUsername, _emailOptions.Value.EmailPassword);
			smtp.Send(email);
			smtp.Disconnect(true);
		}
		#endregion

	}
}
