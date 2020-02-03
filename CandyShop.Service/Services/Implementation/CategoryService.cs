using CandyShop.Domain.Models;
using CandyShop.Persistence.UnitOfWorks;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task EditAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
