using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWTNet.API.Repository;
using JWTNet.Models.CV;
using JWTNet.API.Services;
using Microsoft.AspNetCore.Cors;

namespace JWTNet.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private ICategoryService _categoryService;

        public CategoriesController( ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _categoryService.ListAsync();
        }
    }
}
