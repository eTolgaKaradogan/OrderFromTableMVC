using System;
using System.Linq;
using System.Linq.Expressions;
using _02_Entities.Entities;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using _04_Business.Models;
using _04_Business.Services.Bases;

namespace _04_Business.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepositoryBase _productRepository;

        public ProductService(ProductRepositoryBase productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductModel model, bool saveChanges = true)
        {
            try
            {
                var product = new Product()
                {
                    Guid = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    IsDeleted = false,
                    Details = model.Details,
                    ImagePath = model.ImagePath
                };
                _productRepository.AddEntity(product);
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
                _productRepository.DeleteEntity(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductModel GetById(int id)
        {
            try
            {
                return GetQuery().SingleOrDefault(product => product.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<ProductModel> GetQuery(Expression<Func<ProductModel, bool>> predicate = null)
        {
            try
            {
                return _productRepository.GetEntityQuery(product => product.IsDeleted == false, "Category").Select(product => new ProductModel()
                {
                    Id = product.Id,
                    Guid = product.Guid,
                    Name = product.Name,
                    Price = product.Price,
                    Details = product.Details,
                    CategoryId = product.CategoryId,
                    IsDeleted = product.IsDeleted,
                    ImagePath = product.ImagePath
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
                return _productRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(ProductModel model, bool saveChanges = true)
        {
            try
            {
                var productEntity = _productRepository.GetEntityById(model.Id);
                productEntity.Name = model.Name;
                productEntity.Price = model.Price;
                productEntity.Details = model.Details;
                productEntity.CategoryId = model.CategoryId;
                productEntity.IsDeleted = model.IsDeleted;
                productEntity.ImagePath = model.ImagePath;
                _productRepository.UpdateEntity(productEntity);
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
