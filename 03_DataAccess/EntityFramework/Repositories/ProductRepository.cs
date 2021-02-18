using System;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories
{
    public class ProductRepository : ProductRepositoryBase
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
