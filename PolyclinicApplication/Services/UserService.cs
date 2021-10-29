using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PolyclinicApplication.Data.Models;
using PolyclinicApplication.Services.Interfaces;

#nullable enable

namespace PolyclinicApplication.Services
{
    class UserService : IDataService<User>, IDisposable
    {
        private readonly AppDbContext _db;
        public async Task Create(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }

        public async Task Update(User user, User updatedUser)
        {
            user.Login = updatedUser.Login;
            user.Password = updatedUser.Password;
            user.UserRoleId = updatedUser.UserRoleId;
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll() => await _db.Users.ToListAsync();
        

        public User? GetByLogin(string login) =>_db.Users.FirstOrDefault(x => x.Login == login);
        

        public void Dispose() => _db.Dispose();
    }
}
