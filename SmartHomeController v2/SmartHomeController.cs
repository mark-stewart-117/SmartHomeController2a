using SmartHomeController;
using System.Net.NetworkInformation;

public class Program
{
    private static List<SmartDevice> devices = new List<SmartDevice>();
    public static void Main()
    {

        SmartLight kitchenLight = new SmartLight(1, "Kitchen light", 20.5, "Blue");
        SmartThermostat bathroomThermostat = new SmartThermostat(2, "Bathroom thermostat", 19.0, 25.0);
        SmartSpeaker livingroomSpeaker = new SmartSpeaker(3, "Living room speaker", 20);
        SmartSecurityCamera frontdoorCamera = new SmartSecurityCamera(4, "Front door camera", "2K");

        devices.Add(kitchenLight);
        devices.Add(bathroomThermostat);
        devices.Add(livingroomSpeaker);
        devices.Add(frontdoorCamera);
        
        ViewAllDevices();
    }

    public static void ViewAllDevices()
    {
        Console.WriteLine("List all devices");
        SmartDevice device = null;
        foreach (var smartDevice in devices)
        { 
            smartDevice.GetStatus();
            Console.WriteLine();
        }


    }
       


}
