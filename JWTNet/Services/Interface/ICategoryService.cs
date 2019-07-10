using JWTNet.Models.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Services
{
    public interface ICategoryService
    {
        /// <summary>
        /// Lista de las categorias.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Category>> ListAsync();
    }
}
