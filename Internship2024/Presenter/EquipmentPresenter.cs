using App.DAL.Models;
using App.DAL.Repositories;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Presenter
{
    public class EquipmentPresenter
    {
        private readonly IEquipmentView _equipmentView;
        private readonly IEquimentRepository _equipmentRepository;

        public EquipmentPresenter(IEquipmentView equipmentView,IEquimentRepository equimentRepository)
        {
            _equipmentView = equipmentView;
            _equipmentRepository = equimentRepository;
        }

        public long UpdateEquipment(EquipmentViewModel equipmentViewModel)
        {
            return 0;
        }
    }
}
