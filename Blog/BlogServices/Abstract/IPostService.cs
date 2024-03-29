﻿using BlogEntities.Dtos;
using BlogShared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogServices.Abstract
{
    public interface IPostService
    {
        Task<IDataResult<PostDto>> GetAsync(int id);
        Task<IDataResult<PostListDto>> GetAllAsync();
        Task<IDataResult<PostListDto>> GetAllByNonDeletedAsync();
        Task<IResult> AddAsync(PostAddDto dto, string createdByName);
        Task<IResult> UpdateAsync(PostUpdateDto dto, string createdByName);
        Task<IResult> DeleteAsync(int id, string modifiedByName);
        Task<IResult> HardDeleteAsync(int id);
    }
}
