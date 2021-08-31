﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(Guid idUser);
        Task CreateUser(UserRequest user);
        Task UpdateUser(Guid idUser, UserRequest user);
        Task DeleteUser(Guid idUser);
    }
}