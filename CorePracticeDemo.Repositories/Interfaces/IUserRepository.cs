using CorePracticeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePracticeDemo.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        User Update(User user);
        bool DeleteById(int id);
        User GetById(int id);
        List<User> GetAll();
    }
}
