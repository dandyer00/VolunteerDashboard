using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hack29_WebApp.Repositories
{
    public class UserRespository : BaseRepository
    {
        public UserRespository(Hack29Context c) : base(c)
        {

        }

        public async Task<bool> CreateUser(User u)
        {
            try
            {
                 using (_context)
                {
                    _context.Users.Add(u);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                //log error
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public async Task<User> GetUserByLastName(string lastName)
        {
            var query = from u in _context.Users
                        where u.LastName == lastName
                        select u;

            var user = await query.FirstOrDefaultAsync<User>();

            return user;
        }

        public List<User> GetAllUsers()
        {
            var userList = new List<User>();
            foreach(User u in _context.Users)
            {
                userList.Add(u);
            }
            return userList;

        }
    }
}
