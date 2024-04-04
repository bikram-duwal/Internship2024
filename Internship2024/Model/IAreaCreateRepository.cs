﻿using System.Collections.Generic;

namespace Internship2024.Model
{
    public interface IAreaCreateRepository
    {
        void CreateArea(pl_areaRow _areaRow);
        string GetUniqueCodeFromDatabase();

        List<Department> LoadDepartmentsFromDatabase();
    }
}