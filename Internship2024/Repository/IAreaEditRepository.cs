namespace Internship2024.EditModel
{
    public interface IAreaEditRepository
    {
        void UpdateArea(pl_areaRow objAreaRow);
        pl_areaRow GetAreaByTablePid(long table_pid);
        pl_objectRow[] GetDropDownValue();
        string DropDownName();
    }
}
