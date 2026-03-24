using APBD_Cw2_s24009.Models;

namespace APBD_Cw2_s24009.Services.Tools;

public interface IToolService
{
    public void AddTool(WorkTool workTool);
    public WorkTool GetToolById(int toolId);
    public List<WorkTool> GetAll();
    public List<WorkTool> GetAvailable();
    public void SetAvailable(int toolId);
    public void SetUnavailable(int toolId);
}