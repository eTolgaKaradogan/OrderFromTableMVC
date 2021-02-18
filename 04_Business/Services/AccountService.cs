using System;
using System.Linq;
using System.Linq.Expressions;
using _02_Entities.Entities;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using _04_Business.Models;
using _04_Business.Services.Bases;

namespace _04_Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserRepositoryBase _userRepository;

        public AccountService(UserRepositoryBase userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(UserModel model, bool saveChanges = true)
        {
            try
            {
                if (model.ConfirmPassword != null)
                {
                    if (model.ConfirmPassword == model.Password)
                    {
                        var user = _userRepository.GetEntityQuery(user => user.UserName.ToUpper() == model.UserName.ToUpper() || user.Email.ToUpper() == model.Email.ToUpper()).SingleOrDefault();
                        if (user == null)
                        {
                            var userEntity = new User()
                            {
                                Guid = Guid.NewGuid().ToString(),
                                UserName = model.UserName,
                                RoleId = 2,
                                Password = model.Password,
                                Active = true,
                                Email = model.Email,
                            };
                            _userRepository.AddEntity(userEntity);
                            if (saveChanges)
                            {
                                SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id, bool saveChanges = true)
        {
            try
            {
                _userRepository.DeleteEntity(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserModel GetById(int id)
        {
            try
            {
                return GetQuery().SingleOrDefault(user => user.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<UserModel> GetQuery(Expression<Func<UserModel, bool>> predicate = null)
        {
            try
            {
                return _userRepository.GetEntityQuery("Role").Select(user => new UserModel()
                {
                    Id = user.Id,
                    Guid = user.Guid,
                    UserName = user.UserName,
                    RoleId = user.RoleId,
                    Password = user.Password,
                    Active = user.Active,
                    Email = user.Email,
                    Role = new RoleModel()
                    {
                        Id = user.Role.Id,
                        Guid = user.Role.Guid,
                        Name = user.Role.Name
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveChanges()
        {
            try
            {
                return _userRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(UserModel model, bool saveChanges = true)
        {
            try
            {
                var userEntity = _userRepository.GetEntityById(model.Id);
                userEntity.UserName = model.UserName;
                userEntity.Email = model.Email;
                userEntity.Password = model.Password;
                userEntity.Active = true;
                userEntity.RoleId = model.RoleId;
                _userRepository.UpdateEntity(userEntity);
                if (saveChanges)
                {
                    SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
