using System;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories
{
    public class TableRepository : TableRepositoryBase
    {
        public TableRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
