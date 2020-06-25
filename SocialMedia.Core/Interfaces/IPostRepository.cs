﻿using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByUser(int userId);
        //Task<Post> GetPost(int id);
        //Task InsertPost(Post post);
        //Task<bool> UpdatePost(Post post);
        //Task<bool> DeletePost(int id);
    }
}
