using KaganUnal.Management.Service.Models;

namespace KaganUnal.Management.Service.Services
{
    public interface IEmailService
    {
        //Bu servis implemente edilen sınıf tarafından mail gönderme kurallarının belirlenmesini zorunlu kılacaktır.
        void SendEmail(MailMessage mailMessage);
    }
}
