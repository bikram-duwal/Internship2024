﻿using Internship2024.EditPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.AreaEditView
{
    public interface IAreaEditView
    {
        string UniqueCode { get; set; }
        string AreaName {  get; set; }
        string AreaCode { get; set; }
        string Description { get; set; }
        string DepartmentName { get; set; }
        bool IsActive { get; set; }
        bool IsForDispensing { get; set; }
        AreaEditPresenter Presenter {  get; set; }  
        

    }
}
