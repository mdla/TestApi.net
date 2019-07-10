using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTNet.API.Repository.Interface;
using JWTNet.Models.CV;

namespace JWTNet.API.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        public CategoryService(ICategoryRepository repository) {
            _categoryRepository = repository;
        }

        /// <summary>
        /// Lista las categorias.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
