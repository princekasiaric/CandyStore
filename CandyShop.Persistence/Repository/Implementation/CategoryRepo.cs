﻿using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using System.Collections.Generic;

namespace CandyShop.Persistence.Repository
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context) : base(context){}

        public IEnumerable<Category> GetAllCategorires => AppDbContext.Categories;

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}