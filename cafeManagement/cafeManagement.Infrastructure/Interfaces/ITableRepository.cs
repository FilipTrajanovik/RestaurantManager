using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface ITableRepository
    {
        Task<Table?> GetTableById(Guid id, Guid RestorauntId);
        Task<List<Table>> GetAllTables(Guid RestorauntId);
        void Update(Table table, Guid RestorauntId);
        void Delete(Table table, Guid RestorauntId);
        Task Add(Table table, Guid RestorauntId);
    }
}
