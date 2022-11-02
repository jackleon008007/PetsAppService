using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainDistrict.Domain.Models;
using GrupoWebBackend.DomainDistrict.Domain.Repositories;
using GrupoWebBackend.DomainDistrict.Domain.Services;
using GrupoWebBackend.DomainDistrict.Domain.Services.Communications;
using GrupoWebBackend.Shared.Domain.Repositories;

namespace GrupoWebBackend.DomainDistrict.Services
{
    public class DistrictService: IDistrictService
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DistrictService(IDistrictRepository districtRepository, IUnitOfWork unitOfWork)
        {
            _districtRepository = districtRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<District>> ListAsync()
        {
            return await _districtRepository.ListAsync();
        }



        public async Task<District> FindAsync(int id)
        {
            return await _districtRepository.FindAsync(id);
        }
        
       
}

