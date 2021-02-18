using System;
using System.Linq;
using System.Linq.Expressions;
using _02_Entities.Entities;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using _04_Business.Models;
using _04_Business.Services.Bases;

namespace _04_Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepositoryBase _categoryRepository;

        public CategoryService(CategoryRepositoryBase categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(CategoryModel model, bool saveChanges = true)
        {
            try
            {
                var category = new Category()
                {
                    Name = model.Name,
                };
                _categoryRepository.AddEntity(category);
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

        public void Delete(int id, bool saveChanges = true)
        {
            try
            {
                _categoryRepository.DeleteEntity(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoryModel GetById(int id)
        {
            return GetQuery().SingleOrDefault(category => category.Id == id);
        }

        public IQueryable<CategoryModel> GetQuery(Expression<Func<CategoryModel, bool>> predicate = null)
        {
            try
            {
                return _categoryRepository.GetEntityQuery().Select(category => new CategoryModel()
                {
                    Id = category.Id,
                    Guid = category.Guid,
                    Name = category.Name
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
                return _categoryRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(CategoryModel model, bool saveChanges = true)
        {
            try
            {
                var categoryEntity = _categoryRepository.GetEntityById(model.Id);
                categoryEntity.Name = model.Name;
                _categoryRepository.UpdateEntity(categoryEntity);
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
