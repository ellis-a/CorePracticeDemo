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

        private IQueryable<UserEntity> BaseQuery()
        {
            //allows for user table to be updated with an IsDeleted column for soft deletion
            return _context.User;
        }

        public UserEntity Create(UserEntity userEntity)
        {
            _context.User.Add(userEntity);
            _context.SaveChanges();
            return userEntity;
        }

        public bool DeleteById(int id)
        {
            var user = GetById(id);
            if (user == null) { return false; }

            _context.User.Remove(user);
            _context.SaveChanges();

            return true;
        }

        public List<UserEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public UserEntity GetById(int id)
        {
            var user = BaseQuery()
                .FirstOrDefault(u => u.UserId == id);

            return user;
        }

        public UserEntity Update(UserEntity userEntity)
        {
            _context.User.Attach(userEntity);
            _context.Entry(userEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return userEntity;
        }
    }
}
