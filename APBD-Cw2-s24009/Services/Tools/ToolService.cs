using APBD_Cw2_s24009.Enums;
using APBD_Cw2_s24009.Models;

namespace APBD_Cw2_s24009.Services.Tools;

public class ToolService : IToolService
{
    private readonly List<WorkTool> _tools = [];

    public void AddTool(WorkTool workTool)
    {
        _tools.Add(workTool);
    }

    public WorkTool GetToolById(int toolId)
    {
        return _tools.Find(tool => tool.Id == toolId) ?? throw new Exception("Not found room: " + toolId);
    }

    public List<WorkTool> GetAll()
    {
        return _tools;
    }

    public List<WorkTool> GetAvailable()
    {
        return _tools.Where(tool => tool.Status == ToolStatus.Available).ToList();
    }

    public void SetAvailable(int toolId)
    {
        GetToolById(toolId).Status = ToolStatus.Available;
    }

    public void SetUnavailable(int toolId)
    {
        GetToolById(toolId).Status = ToolStatus.Unavailable;
    }
}