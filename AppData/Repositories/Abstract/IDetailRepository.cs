using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppData.Repositories.Abstract
{
    public interface IDetailRepository
    {
        Task<List<Detail>> GetDetailsAsync();

        Task DeleteDetailAsync(int id, DateTime removeDateTime);

        Task<bool> ExistsAsync(int id);

        Task AddDetailAsync(Detail detail);

        Task UpdateDetailAsync(Detail detail);

        Task<DateTime> GetCreatedDateByIdAsync(int id);
    }
}
