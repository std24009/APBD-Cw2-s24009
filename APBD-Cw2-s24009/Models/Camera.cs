namespace APBD_Cw2_s24009.Models;

public class Camera(string name, float videoMaxLenght, string resolution) : WorkTool(name)
{
    public float VideoMaxLenght { get; set; } = videoMaxLenght;
    public string Resolution { get; set; } = resolution;
}