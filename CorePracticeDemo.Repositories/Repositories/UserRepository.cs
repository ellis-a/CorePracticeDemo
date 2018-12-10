using System;
using System.Collections.Generic;
using CorePracticeDemo.Data;
using CorePracticeDemo.Entities;
using CorePracticeDemo.Repositories.Interfaces;
using System.Linq;
using System.Data.Entity;

namespace CorePracticeDemo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DemoDataContext _context;

        public UserRepository(DemoDataContext context)
        {
            _context = context;
        }

        private IQueryable<User> BaseQuery()
        {
            //allows for user table to be updated with an IsDeleted column for soft deletion
            return _context.User;
        }

        public User Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool DeleteById(int id)
        {
            var user = GetById(id);
            if (user == null) { return false; }

            _context.User.Remove(user);
            _context.SaveChanges();

            return true;
        }

        public List<User> GetAll()
        {
            return BaseQuery().ToList();
        }

        public User GetById(int id)
        {
            var user = BaseQuery()
                .FirstOrDefault(u => u.UserId == id);

            return user;
        }

        public User Update(User user)
        {
            _context.User.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return user;
        }
    }
}
