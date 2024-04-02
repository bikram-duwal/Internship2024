using Internship2024.Model;
using Internship2024.Repository;
using System.Collections.Generic;


namespace Internship2024.Services
{
    internal class AreaLandingService : IAreaLandingService
    {
        IAreaLandingRepository _repository;
        public AreaLandingService(IAreaLandingRepository repository) {
            _repository = repository;
        }
        public List<pl_areaRow> getAllAreaRows()
        {
            return _repository.getAllAreaRows();
        }
    }
}
