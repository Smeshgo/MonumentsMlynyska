﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class UserRepositorieImpl: RepositoryBaseImpl<User>, IUserRepositorie
    {
        public UserRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToListAsync();

        public async Task<User> GetUserById(Guid idUser)
        {
            return await FindByCondition(x => x.IdUser.Equals(idUser))
                .FirstOrDefaultAsync();
        }

        public User GetUserWithDetails(Guid idUser)
        {
            return FindByCondition(owner => owner.IdUser.Equals(idUser)).FirstOrDefault();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}