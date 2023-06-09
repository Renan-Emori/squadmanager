﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Context;
using Repository.Entity;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        protected EFContext _dataContext;

        public UserRepository(EFContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public void Add(UserEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }

        public void Update(UserEntity entity)
        {
            _dataContext.Update(entity);
            _dataContext.SaveChanges();
        }

        public UserEntity Login(UserEntity entity)
        {
            return _dataContext.Users.FirstOrDefault(o =>
            o.Password == entity.Password &&
            (o.Person.Email == entity.Person.Email || o.Person.Username == entity.Person.Username));
        }
    }
}
