using Hack29_WebApp.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hack29_WebApp.Repositories
{
    public class BaseRepository
    {

        protected Hack29Context _context;

        public BaseRepository(Hack29Context c)
        {
            _context = c;
        }
    }
}
