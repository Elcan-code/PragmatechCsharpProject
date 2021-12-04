﻿using BlogShared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntities.Concrete
{

    public class Post : EntityBase, IEntity
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }


        public Category Category { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public void SetViewCount()
        {
            this.ViewsCount += 1;
        }
    } 
    }
