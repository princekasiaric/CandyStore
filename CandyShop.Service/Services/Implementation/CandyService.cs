using CandyShop.Domain.Models;
using CandyShop.Persistence.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class CandyService : ICandyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CandyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Candy> GetAllCandies => _unitOfWork.Candies.GetAllCandy;

        public IEnumerable<Candy> GetCandiesOnSale => _unitOfWork.Candies.GetCandyOnSale;

        public IEnumerable<Candy> GetCandyByOrderBy => _unitOfWork.Candies.GetCandyByOrderBy;

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

        public Candy GetCandyByIdAsync(int candyId)
        {
            return _unitOfWork.Candies.GetCandyById(candyId);
        }

        public IEnumerable<Candy> GetCandyWithCategory(string category)
        {
            return _unitOfWork.Candies.FindByCondition(c => c.Category.CategoryName == category);
        }
    }
}
