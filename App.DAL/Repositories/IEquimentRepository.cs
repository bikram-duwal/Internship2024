using App.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public interface IEquimentRepository
    {
        void GetEquipment();
        long UpdateEquipment(EquipmentViewModel equipment);
    }
}
