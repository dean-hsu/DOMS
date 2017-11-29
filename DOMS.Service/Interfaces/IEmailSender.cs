using System.Threading.Tasks;

namespace DOMS.Service.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
