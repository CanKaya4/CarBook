using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers.Read
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var values = await _repository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandName = x.Brand.BrandName,
                BrandId = x.BrandId,
                CarId = x.CarId,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Luggage = x.Luggage,
                Milage = x.Milage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
            }).ToList();
        }
    }
}
