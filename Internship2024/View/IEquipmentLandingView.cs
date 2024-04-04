using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;

namespace Internship2024.View
{
    public interface IEquipmentLandingView
    {
        UltraGrid UGEquipmentLanding { get; }
        EquipmentLandingPresenter Presenter { get; set; }
    }
}
