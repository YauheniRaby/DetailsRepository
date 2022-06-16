using AppData.Repositories.Abstract;
using AppData.Model;
using AppServices.Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using AppServices.DTOs;
using AutoMapper;

namespace AppServices.Services
{
    public class DetailService : IDetailService
    {
        private readonly IDetailRepository _detailRepository;
        private readonly IMapper _mapper;

        public DetailService(IDetailRepository detailRepository, IMapper mapper )
        {
            _detailRepository = detailRepository;
            _mapper = mapper;
        }

        public async Task<List<DetailDTO>> GetDetailsAsync()
        {
            var result = await _detailRepository.GetDetailsAsync();
            return _mapper.Map<List<DetailDTO>>(result);
        }

        public Task AddDetailAsync(CreateDetailDTO createDetailDto) 
        {
            var detail = _mapper.Map<Detail>( createDetailDto );
            return _detailRepository.AddDetailAsync(detail);
        }

        public Task DeleteDetailAsync(int id)
        {
            return _detailRepository.DeleteDetailAsync(id, DateTime.Now);
        }

        public Task<bool> ExistsAsync(int id)
        {
            return _detailRepository.ExistsAsync(id);
        }

        public async Task UpdateDetailAsync(UpdateDetailDTO updateDetailDto)
        {
            var detail = _mapper.Map<Detail>(updateDetailDto);
            detail.CreatedDate = await _detailRepository.GetCreatedDateByIdAsync(updateDetailDto.Id);
            await _detailRepository.UpdateDetailAsync(detail);
        }
    }
}
