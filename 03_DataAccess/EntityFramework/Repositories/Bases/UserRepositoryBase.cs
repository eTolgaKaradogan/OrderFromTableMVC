using System;
using _02_Entities.Entities;
using AppCore.DataAccess.Bases.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories.Bases
{
    public class UserRepositoryBase : RepositoryBase<User>
    {
        protected UserRepositoryBase(DbContext dbContext) : base (dbContext)
        {

        }
    }
}
