using LoanTapeService.Models;

namespace LoanTapeService.Controllers
{
    public interface INotificationService
    {
        void Send(ServicingEvent servicingEvent);
    }
}