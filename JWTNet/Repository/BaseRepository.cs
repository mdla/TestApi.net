using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTNet.API.Repository
{
    public abstract class BaseRepository
    {
        protected readonly JWTNetAPIContext _context;

        public BaseRepository(JWTNetAPIContext context)
        {
            _context = context;
        }
    }
}
