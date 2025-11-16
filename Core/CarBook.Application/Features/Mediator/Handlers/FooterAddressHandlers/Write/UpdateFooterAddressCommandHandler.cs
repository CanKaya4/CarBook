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
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddres> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddres> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.FooterAddresId);
            value.PhoneNumber = request.PhoneNumber;
            value.Address = request.Address;
            value.Description = request.Description;
            value.Email = request.Email;
        }
    }
}
