using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers.Write
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddres> _repository;

        public CreateFooterAddressCommandHandler(IRepository<FooterAddres> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddres
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
            });
        }
    }
}
