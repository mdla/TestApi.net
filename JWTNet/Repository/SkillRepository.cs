using JWTNet.API.Repository.Interface;
using JWTNet.Models.CV;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Repository
{
    public class SkillRepository : BaseRepository, ISkillRepository
    {
        public SkillRepository(JWTNetAPIContext context) : base(context)
        {
        }

        /// <summary>
        /// Listado de las skills
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Skill>> ListAsync()
        {
            return await _context.Skill.ToListAsync();
        }
    }
}
