using System;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace _03_DataAccess.EntityFramework.Repositories
{
    public class UserRepository : UserRepositoryBase
    {
        public UserRepository(DbContext dbContext) : base (dbContext)
        {

        }
    }
}
