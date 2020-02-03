using AutoMapper;
using CandyShop.Domain.Models;
using CandyShop.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class CandyService : ICandyService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;

        public CandyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_mapper = mapper;
        }

        public IEnumerable<Candy> GetAllCandies => _unitOfWork.Candies.GetAllCandy;

        public IEnumerable<Candy> GetCandiesOnSale => _unitOfWork.Candies.GetCandyOnSale;

        public async Task CreateAsync(Candy candy)
        {
            await _unitOfWork.Candies.Add(candy);
            await _unitOfWork.CommitAsync();
            _unitOfWork.Dispose();

        }

        public async Task DeleteAsync(Candy candy)
        {
                _unitOfWork.Candies.Remove(candy);
                await _unitOfWork.CommitAsync();
                _unitOfWork.Dispose();
        }

        public async Task EditAsync(Candy candy)
        {
            _unitOfWork.Candies.Update(candy);
            await _unitOfWork.CommitAsync();
            _unitOfWork.Dispose();
        }

        public async Task<Candy> GetCandyById(int id)
        {
            return await _unitOfWork.Candies.GetCandyById(id);
        }
    }
}
