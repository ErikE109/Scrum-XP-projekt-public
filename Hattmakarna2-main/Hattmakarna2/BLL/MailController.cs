using nDumbster.Smtp;
using System.Net.Mail;

public class MailController
{

    int emails;
    SimpleSmtpServer _server;
    IEnumerable<MailMessage> mailM1 = new List<MailMessage>();


    public MailController()
    {
        _server = SimpleSmtpServer.Start(25);
    }

    public void SendConfirmationEmail(string emailAddress)
    {
        var client = new SmtpClient("localhost", 25);

        var message = new MailMessage("order@hattmakarna.se", emailAddress, "Orderbekräftelse", "Se bifogad faktura\nTack för din beställning!");

        Attachment attachment = new Attachment(@".\faktura.pdf");

        message.Attachments.Add(attachment);

        client.Send(message);

        attachment.Dispose();
        emails = _server.ReceivedEmailCount;
        mailM1 = _server.ReceivedEmail;

    }

    public int GetEmails()
    {
        return emails;
    }

    public IEnumerable<MailMessage> GetMailMessages()
    {
        return mailM1;
    }



    public void Stop()
    {
        _server.Stop();
    }

}