using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppData.Repositories.Abstract
{
    public interface IDetailRepository
    {
        Task<List<Detail>> GetAsync();

        Task DeleteAsync(int id, DateTime removeDateTime);

        Task<bool> ExistsAsync(int id);

        Task AddAsync(Detail detail);

        Task UpdateAsync(Detail detail);

        Task<DateTime> GetCreatedDateByIdAsync(int id);
    }
}
