﻿using BlogEntities.Concrete;
using BlogShared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntities.Dtos
{
    public class PostDto : GetBaseDto
    {
        public Post Entity { get; set; }
    }

    public class PostListDto : GetBaseDto
    {
        public IList<Post> Entities { get; set; }
    }
}
