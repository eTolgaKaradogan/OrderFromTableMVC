using System;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories
{
    public class ProductTableRepository : ProductTableRepositoryBase
    {
        public ProductTableRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
