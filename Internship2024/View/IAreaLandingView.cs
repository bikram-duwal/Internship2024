using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;

namespace Internship2024.View
{
    public interface IAreaLandingView
    {
        UltraGrid UGAreaLanding { get; }
        AreaLandingPresenter _presenter { get; set; }
    }
}
