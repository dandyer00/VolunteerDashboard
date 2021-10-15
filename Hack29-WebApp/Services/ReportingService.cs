using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
using Hack29_WebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hack29_WebApp.Services
{
    public class ReportingService
    {

        private UserRespository _userRepo;
        private EventRepository _eventRepo;

        public ReportingService()
        {
            Hack29Context _context = new Hack29Context();
            _userRepo = new UserRespository(_context);
            _eventRepo = new EventRepository(_context);
        }
        public ReportingService( UserRespository ur, EventRepository er)
        {

            _eventRepo = er;
            _userRepo = ur;
        }

        public List<User> GetAllUsers()
        { 
            List<User> uList = _userRepo.GetAllUsers();
            return uList;
        }

        public List<Event> GetEventsForUser(int userId)
        {
            List<Event> eList = _eventRepo.GetEventsByUserId(userId);
            return eList;
        }
    }
}
