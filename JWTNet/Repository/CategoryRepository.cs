using JWTNet.API.Repository.Interface;
using JWTNet.Models.CV;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Repository
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(JWTNetAPIContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Category.Include(x => x.Skills).ToListAsync();
        }
    }
}
