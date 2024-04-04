using Internship2024.Model;
using Internship2024.Repository;
using System.Collections.Generic;


namespace Internship2024.Services
{
    internal class EquipmentLandingService : IEquipmentLandingService
    {
        IEquipmentLandingRepository _repository;
        public EquipmentLandingService(IEquipmentLandingRepository repository) {
            _repository = repository;
        }
        public   List<Equipment> getAllEquipmentRows()
        {
            return _repository.getAllEquipmentRows();
        }
    }
}
