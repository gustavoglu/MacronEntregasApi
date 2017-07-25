using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Macron.Entregas.Application.ViewModels;
using Macron.Entregas.Domain.Core.Notifications;
using Macron.Entregas.Domain.Core.Bus;
using AutoMapper;
using Macron.Entregas.Domain.Interfaces.EntityRepository;
using Macron.Entregas.Domain.Models.Entregas.Commands;
using Macron.Entregas.Application.Interfaces;

namespace Macron.Entregas.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Entregas")]
    public class EntregasController : BaseController
    {
        private readonly IEntregaRepository _entregaRepository;
        private readonly IEntregaAppService _entregaAppService;
        private readonly IBus _bus;
        private readonly IMapper _mapper;

        public EntregasController(IEntregaAppService entregaAppService, IEntregaRepository entregaRepository, IMapper mapper, IBus bus, IDomainNotificationHandler<DomainNotification> domainNotificatoinHandler) : base(bus, domainNotificatoinHandler)
        {
            _entregaRepository = entregaRepository;
            _entregaAppService = entregaAppService;
            _mapper = mapper;
            _bus = bus;
        }
        // GET: api/Entregas
        [HttpGet]
        public IEnumerable<EntregaViewModel> Get()
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.TrazerTodosAtivos());
        }

        [HttpGet("{id:Guid}", Name = "Get")]
        public EntregaViewModel Get(Guid id)
        {
            return _mapper.Map<EntregaViewModel>(_entregaRepository.TrazerAtivoPorId(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]EntregaViewModel entrega)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }

            var criarCommand = _mapper.Map<CriarEntregaCommand>(entrega);
            _bus.SendCommand(criarCommand);

            return Response(criarCommand);

        }

        [HttpPost]
        [Route("api/Entregas/Reativar/{id:Guid}")]
        public IActionResult Reativar(Guid id)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }

            var reativarCommand = _mapper.Map<ReativarEntregaCommand>(id);
            _bus.SendCommand(reativarCommand);

            return Response(reativarCommand);
        }

        [HttpPut("{id:Guid}")]
        public IActionResult Put(Guid id, [FromBody]EntregaViewModel entrega)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }

            var atualizarCommand = _mapper.Map<AtualizarEntregaCommand>(entrega);
            _bus.SendCommand(atualizarCommand);

            return Response(atualizarCommand);
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }
            var deletarCommand = new DeletarEntregaCommand(id);
            _bus.SendCommand(deletarCommand);

            return Response(deletarCommand);
        }

    }
}
