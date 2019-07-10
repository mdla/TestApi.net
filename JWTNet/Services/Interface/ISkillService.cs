using JWTNet.Models.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Services.Interface
{
    public interface ISkillService
    {
        /// <summary>
        /// Lista de las skills.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Skill>> ListAsync();
    }
}
