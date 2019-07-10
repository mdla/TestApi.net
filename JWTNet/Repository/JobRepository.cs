using JWTNet.API.Repository.Interface;
using JWTNet.Models.CV;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Repository
{
    public class JobRepository : BaseRepository, IJobRepository
    {
        public JobRepository(JWTNetAPIContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Job>> ListAsync()
        {
            return  await _context.Job.ToListAsync();
        }
    }
}
