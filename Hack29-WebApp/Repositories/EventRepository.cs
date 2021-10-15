using Hack29_WebApp.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hack29_WebApp.Repositories
{
    public class EventRepository : BaseRepository
    {
        public EventRepository(Hack29Context c) : base(c)
        {

        }
    }
}
