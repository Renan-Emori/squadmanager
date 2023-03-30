 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entity;

namespace Repository
{
    public interface IUserRepository
    {
        public void Add(UserEntity entity);

        public void Update(UserEntity entity);

        public UserEntity Login(UserEntity entity);
    }
}
