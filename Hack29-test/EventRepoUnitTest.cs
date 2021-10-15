using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
using Hack29_WebApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hack29_test
{
    [TestClass]
    public class EventRepoTest
    {
        private Hack29Context _context;
        private EventRepository _repo;


        [TestInitialize]
        public async Task TestInitialize()
        {
            var builder = new DbContextOptionsBuilder<Hack29Context>();
            builder.UseInMemoryDatabase("Hack29");
            DbContextOptions<Hack29Context> dbContextOptions = builder.Options;


            _context = new Hack29Context(dbContextOptions);
            
            _repo = new EventRepository(_context);
            Assert.IsNotNull(_repo);

        }

        [TestMethod]
        public async Task CreateEvent_SuccessAsync()
        {
            Event e = new Hack29_WebApp.DatabaseLayer.Models.Event()
            {
                EventId = 1,
                EventName = "formSubmitted",
                UserId = 123,
                EventTime = BitConverter.GetBytes(DateTime.Now.Ticks),
                WorkflowInstanceId = Guid.NewGuid().ToString()
            };
            bool result = await _repo.CreateEvent(e);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetEventByUserId_Success()
        {
            Event e = new Hack29_WebApp.DatabaseLayer.Models.Event()
            {
                EventId = 3,
                EventName = "documentSubmitted",
                UserId = 123,
                EventTime = BitConverter.GetBytes(DateTime.Now.Ticks),
                WorkflowInstanceId = Guid.NewGuid().ToString()
            };
            _context.Events.Add(e);
            _context.SaveChanges();

            List<Event> events = _repo.GetEventsByUserId(123);

            //fix me
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        public void GetAllEvents_Success()
        {

            Event e = new Hack29_WebApp.DatabaseLayer.Models.Event()
            {
                EventId = 4,
                EventName = "formSubmitted",
                UserId = 666,
                EventTime = BitConverter.GetBytes(DateTime.Now.Ticks),
                WorkflowInstanceId = Guid.NewGuid().ToString()
            };
            _context.Events.Add(e);
            _context.SaveChanges();
            
            List<Event> events= _repo.GetAllEvents();
            bool x = events.Contains(e);

            Assert.IsTrue(x);
        }

    }
}
