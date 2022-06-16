using AppServices.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppServices.Services.Abstract
{
    public interface IDetailService
    {
        Task<List<DetailDTO>> GetAsync();

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id);

        Task AddAsync(CreateDetailDTO createDetailDto);

        Task UpdateAsync(UpdateDetailDTO updateDetailDto);
    }
}
