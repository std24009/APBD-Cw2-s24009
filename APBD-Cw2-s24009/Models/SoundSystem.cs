namespace APBD_Cw2_s24009.Models;

public class SoundSystem(string name, string microphoneType, bool isWireless) : WorkTool(name)
{
    public string MicrophoneType { get; set; } = microphoneType;
    public bool IsWireless { get; set; } = isWireless;
}