using System;
using _02_Entities.Entities;
using AppCore.DataAccess.Bases.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories.Bases
{
    public class TableRepositoryBase : RepositoryBase<Table>
    {
        public TableRepositoryBase(DbContext dbContext) : base (dbContext)
        {

        }
    }
}
