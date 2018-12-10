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
        UserEntity Create(UserEntity userEntity);
        UserEntity Update(UserEntity userEntity);
        bool DeleteById(int id);
        UserEntity GetById(int id);
        List<UserEntity> GetAll();
    }
}
