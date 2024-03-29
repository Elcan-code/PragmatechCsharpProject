﻿using BlogEntities.Concrete;
using BlogShared.Data;
using BlogShared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogData.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
}
