using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWTNet.API.Repository;
using JWTNet.Models.CV;
using JWTNet.API.Repository.Interface;
using Microsoft.AspNetCore.Cors;
using JWTNet.API.Services;
using JWTNet.API.Services.Interface;

namespace JWTNet.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private ISkillService _skillService;

        public SkillsController(ISkillService service)
        {
            _skillService = service;
        }

        // GET: api/Skills
        [HttpGet]
        public async Task<IEnumerable<Skill>> GetSkill()
        {
            return await _skillService.ListAsync();
        }


    }
}
