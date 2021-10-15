using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
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

        public async Task<bool> CreateEvent(Hack29_WebApp.DatabaseLayer.Models.Event e)
        {
            try
            {
                using (_context)
                {
                    _context.Events.Add(e);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                //log error
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }

        public List<Hack29_WebApp.DatabaseLayer.Models.Event> GetEventsByUserId(int userId)
        {
            var events = _context.Events.Where(e => e.UserId == userId).ToList<Event>();
            return events;

        }

        public List<Event> GetAllEvents()
        {
            var events = _context.Events.ToList<Event>();
            return events;
        }
    }
}
