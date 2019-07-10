using JWTNet.Models.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Repository.Interface
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> ListAsync();
    }
}

