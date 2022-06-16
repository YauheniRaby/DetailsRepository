using AppServices.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppServices.Services.Abstract
{
    public interface IDetailService
    {
        Task<List<DetailDTO>> GetDetailsAsync();

        Task DeleteDetailAsync(int id);

        Task<bool> ExistsAsync(int id);

        Task AddDetailAsync(CreateDetailDTO createDetailDto);

        Task UpdateDetailAsync(UpdateDetailDTO updateDetailDto);
    }
}
