using System;
using System.Collections.Generic;
using CorePracticeDemo.Data;
using CorePracticeDemo.Entities;
using CorePracticeDemo.Repositories.Interfaces;
using System.Linq;

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
            throw new NotImplementedException();
        }

        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
