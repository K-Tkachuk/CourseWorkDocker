﻿using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class FireplaceService : IFireplaceService
    {
        private readonly IFireplaceRepository _fireplaceRepository;
        public FireplaceService(IFireplaceRepository fireplaceRepository) 
        {
            _fireplaceRepository = fireplaceRepository;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken)
        {
            return await _fireplaceRepository.GetByProductType(type);
        }

        public Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
