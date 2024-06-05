﻿using Entities;

namespace Repository
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<User> Login(UserLogin userLogin);
        Task<User> Register(User user);
        Task<User> Update(int id, User userToUpdate);
    }
}