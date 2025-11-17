using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;


namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers.Write
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public UpdatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }


        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.PricingId);
            value.PricingName = request.PricingName;

            await _repository.UpdateAsync(value);
        }
    }
}
