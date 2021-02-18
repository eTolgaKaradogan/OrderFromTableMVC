using System;
using System.Linq;
using System.Linq.Expressions;
using _02_Entities.Entities;
using _03_DataAccess.EntityFramework.Repositories.Bases;
using _04_Business.Models;
using _04_Business.Services.Bases;

namespace _04_Business.Services
{
    public class TableService : ITableService
    {
        private readonly TableRepositoryBase _tableRepository;

        public TableService(TableRepositoryBase tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public void Add(TableModel model, bool saveChanges = true)
        {
            try
            {
                var table = new Table()
                {
                    Name = model.Name,
                    TotalPrice = model.TotalPrice,
                    OrderNote = model.OrderNote
                };
                _tableRepository.AddEntity(table);
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
                _tableRepository.DeleteEntity(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TableModel GetById(int id)
        {
            try
            {
                return GetQuery().SingleOrDefault(table => table.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<TableModel> GetQuery(Expression<Func<TableModel, bool>> predicate = null)
        {
            try
            {
                return _tableRepository.GetEntityQuery().Select(table => new TableModel()
                {
                    Id = table.Id,
                    Guid = table.Guid,
                    Name = table.Name,
                    TotalPrice = table.TotalPrice,
                    OrderNote = table.OrderNote
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
                return _tableRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TableModel model, bool saveChanges = true)
        {
            try
            {
                var tableEntity = _tableRepository.GetEntityById(model.Id);
                tableEntity.Name = model.Name;
                tableEntity.TotalPrice = model.TotalPrice;
                tableEntity.OrderNote = model.OrderNote;
                _tableRepository.UpdateEntity(tableEntity);
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
