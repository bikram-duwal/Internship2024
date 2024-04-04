using Internship2024;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public interface IEquipmentRepository
    {
        void LoadCombos();
        pl_equipmentRow GetEquipment(long equipmentId);
        void UpdateEquipment(pl_equipmentRow equipmentRow);
    }
}
