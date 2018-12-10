using CorePracticeDemo.Entities;
using CorePracticeDemo.Repositories.Interfaces;
using CorePracticeDemo.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace CorePracticeDemo.Services
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private User EntityToUser(UserEntity userEntity)
        {
            return new User()
            {
                Id = userEntity.UserId,
                DateOfBirth = userEntity.DateOfBirth,
                Email = userEntity.Email,
                FirstName = userEntity.Firstname,
                LastName = userEntity.Lastname,
                Mobile = userEntity.Mobile,
                Password = userEntity.Password,
                Phone = userEntity.Phone,
                Username = userEntity.Username
            };
        }

        public User GetById(int id)
        {
            var user = _userRepository.GetById(id);
            return EntityToUser(user);
        }

        public List<User> GetAll()
        {
            var userEntities = _userRepository.GetAll();
            var users = userEntities.Select(u => EntityToUser(u)).ToList();
            return users;
        }

        public User Create(User user)
        {
            var userEntity = _userRepository.Create(new UserEntity()
            {
                UserId = user.Id,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Mobile = user.Mobile,
                Password = user.Password,
                Phone = user.Phone,
                Username = user.Username
            });

            return EntityToUser(userEntity);
        }

        public User Update(User user)
        {
            var userEntity = _userRepository.GetById(user.Id);

            userEntity.UserId = user.Id;
            userEntity.DateOfBirth = user.DateOfBirth;
            userEntity.Email = user.Email;
            userEntity.Firstname = user.FirstName;
            userEntity.Lastname = user.LastName;
            userEntity.Mobile = user.Mobile;
            userEntity.Password = user.Password;
            userEntity.Phone = user.Phone;
            userEntity.Username = user.Username;

            _userRepository.Update(userEntity);

            return EntityToUser(userEntity);
        }

        public bool Delete(User user)
        {
            return _userRepository.DeleteById(user.Id);
        }

    }
}
