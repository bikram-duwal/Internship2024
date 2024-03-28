using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.View
{
    public interface IAreaLandingView
    {
        UltraGrid GridAreaLanding { get; }
        AreaLandingPresenter Presenter { get; set; }
    }
}
