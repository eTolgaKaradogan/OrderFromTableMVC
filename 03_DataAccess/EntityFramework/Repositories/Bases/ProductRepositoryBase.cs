using System;
using _02_Entities.Entities;
using AppCore.DataAccess.Bases.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories.Bases
{
    public class ProductRepositoryBase : RepositoryBase<Product>
    {
        public ProductRepositoryBase(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
