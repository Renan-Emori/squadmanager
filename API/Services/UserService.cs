using Common;
using Repository;
using Repository.Entity;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                PersonID = model.PersonId,
                Password = model.Password,
                Type = Enumtype.ADMIN.ToString()
            };
            _userRepository.Add(entity);
        }

        public void UpdateUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Id = model.Id,
                PersonID = model.PersonId,
                Password = model.Password,
                Type = model.Type
            };
            _userRepository.Update(entity);
        }

        public UserModel Login(UserModel model) 
        {
            UserEntity entity = new UserEntity()
            {
                Person = new PersonEntity()
                {
                    Email = model.Person.Email,
                    Username = model.Person.Username,  
                },
                Password = model.Password
            };
            entity = _userRepository.Login(entity);
            return model;
        }
    } 
}
