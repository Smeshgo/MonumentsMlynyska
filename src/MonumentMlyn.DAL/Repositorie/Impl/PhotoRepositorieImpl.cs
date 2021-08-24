﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class PhotoRepositorieImpl : RepositoryBaseImpl<Photo>,IPhotoRepositorie
    {
        public PhotoRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Photo>> GetAllPhoto(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();
        public async Task<Photo> GetPhotoById(Guid idPhoto)
        {
            return await FindByCondition(x => x.IdPhoto.Equals(idPhoto))
                .FirstOrDefaultAsync();
        }

        public Photo GetPhotoWithDetails(Guid idPhoto)
        {
            return FindByCondition(owner => owner.IdPhoto.Equals(idPhoto)).FirstOrDefault();
        }

        public void CreatePhoto(Photo photo)
        {
            Create(photo);
        }

        public void UpdatePhoto(Photo photo)
        {
            Update(photo);
        }

        public void DeletePhoto(Photo photo)
        {
           Delete(photo);
        }
    }
}