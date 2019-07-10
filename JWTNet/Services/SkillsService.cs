using JWTNet.API.Repository.Interface;
using JWTNet.API.Services.Interface;
using JWTNet.Models.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Services
{
    public class SkillsService: ISkillService
    {
        private ISkillRepository _skillRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        public SkillsService(ISkillRepository repository)
        {
            _skillRepository = repository;
        }

        /// <summary>
        /// Lista de skills.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Skill>> ListAsync()
        {
            return await _skillRepository.ListAsync();
        }
    }
}
