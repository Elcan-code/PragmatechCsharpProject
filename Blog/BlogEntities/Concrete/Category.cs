﻿using System.Collections.Generic;
using BlogShared.Entities.Abstract;

namespace BlogEntities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public Category()
        {

        }
        public Category(string name, string description) : this()
        {
            this.Name = name;
            this.Description = description;
        }
        public Category(string name, string description, string note) : base(note)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        // relations
        public ICollection<Post> Posts { get; set; }
    }
}