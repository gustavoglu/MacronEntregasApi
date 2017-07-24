using Microsoft.AspNetCore.Mvc;
using Macron.Entregas.Domain.Core.Notifications;
using System.Linq;
using Macron.Entregas.Domain.Core.Bus;

namespace Macron.Entregas.API.Controllers
{
    public class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainNotification> _domainNotificationHandler;
        private readonly IBus _bus;

        public BaseController(IBus bus,IDomainNotificationHandler<DomainNotification> domainNotificationHandler)
        {
            _domainNotificationHandler = domainNotificationHandler;
            _bus = bus;
        }

        public new IActionResult Response(object obj = null)
        {
            if (!OperationIsValid())
            {
                return BadRequest(new
                {
                    success = false,
                    errors = _domainNotificationHandler.GetNotifications().Select(n => n.Value)
                });
            }

            return Ok(new
            {
                success = true,
                data = obj
            });

        }

        protected bool OperationIsValid()
        {
            return !_domainNotificationHandler.HasNotifications();
        }

        protected void NotificarErro(string codigo,string mensagem)
        {
            _bus.RaizeEvent(new DomainNotification(codigo, mensagem));
        }

        protected void NotificarErroModelInvalida()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);

            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(string.Empty, erroMsg);
            }
        }
    }
}