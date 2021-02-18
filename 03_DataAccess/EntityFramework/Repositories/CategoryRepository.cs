using System;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories
{
    public class CategoryRepository : CategoryRepositoryBase
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
