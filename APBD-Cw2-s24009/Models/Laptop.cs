namespace APBD_Cw2_s24009.Models;

public class Laptop(string name, string operationSystem, bool hasAdditionalMouse) : WorkTool(name)
{
    public bool HasAdditionalMouse { get; set; } = hasAdditionalMouse;
    public string OperatingSystem { get; set; } = operationSystem;
}