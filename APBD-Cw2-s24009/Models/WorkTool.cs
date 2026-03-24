using APBD_Cw2_s24009.Enums;

namespace APBD_Cw2_s24009.Models;

public abstract class WorkTool(string name)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public string Name { get; set; } = name;
    public ToolStatus Status { get; set; } = ToolStatus.Available;
}