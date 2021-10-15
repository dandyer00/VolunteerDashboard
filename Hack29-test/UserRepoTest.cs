using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
using Hack29_WebApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hack29_test
{
    [TestClass]
    public class UserRepoTest
    {
        private Hack29Context _context;
        private UserRespository _repo;


        [TestInitialize]
        public async Task TestInitialize()
        {
            var builder = new DbContextOptionsBuilder<Hack29Context>();
            builder.UseInMemoryDatabase("Hack29");
            DbContextOptions<Hack29Context> dbContextOptions = builder.Options;


            _context = new Hack29Context(dbContextOptions);
            
            _repo = new UserRespository(_context);
            Assert.IsNotNull(_repo);

        }

        [TestMethod]
        public async Task CreateUser_SuccessAsync()
        {
            User u = CreateRosa(false);
            bool result = await _repo.CreateUser(u);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task GetUserByLastName_SuccessAsync()
        {
            CreateGus(true);
            string lastName = "BigDog";
            User u = await _repo.GetUserByLastName(lastName);
            Assert.AreEqual(lastName, u.LastName);
        }

        [TestMethod]
        public void GetAllUsers_Success()
        {
            User eddy = CreateEddy(true);
            User joey = CreateJoey(true);
            List<User> users= _repo.GetAllUsers();

            if (users.Contains(joey) && users.Contains(eddy))
                Assert.IsTrue(true);
        }

        private User CreateRosa(bool persist =  false)
        {
            var u = CreateTestUser(666, "Rosa", "PsychoCat", "rosa@yahoo.com", "USA", "666-666-6666", "1234", persist);
            return u;
        }

        private User CreateGus(bool persist = false)
        {
            var u = CreateTestUser(123, "Gus", "BigDog", "gus@gmail.com", "USA", "123-456-7890", "83702", persist);
            return u;
        }

        private User CreateEddy(bool persist = false)
        {
            var u = CreateTestUser(124, "Eddy", "TheDog", "eddy@gmail.com", "USA", "123-456-7890", "83702", persist);
            return u;
        }
        private User CreateJoey(bool persist = false)
        {
            var u = CreateTestUser(125, "Joey", "GrumpyCat", "grumpy@gmail.com", "USA", "111-222-3333", "83702", persist);
            return u;
        }
        private User CreateTestUser(int userId, string firstName, string lastName, string email, string location, string phone, string postalCode, bool persist=false)
        {
            User u = new User()
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Location = location,
                Phone = phone,
                PostalCode = postalCode
            };

            if (persist)
            {
                _context.Users.Add(u);
                _context.SaveChanges();
            }
            return u;
        }
    }
}
