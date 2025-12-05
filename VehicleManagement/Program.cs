
// Console.WriteLine("Hello, Customer!");

// var vehicle1 = new Vehicle("Trailer", "Ford", "2025");
// var vehicle2 = new Vehicle ("Mercedes Benz", "Mercedes", "1990");

// List<Vehicle> vehicles = [vehicle1, vehicle2];
// Console.WriteLine($"{vehicle1.VehicleName}, {vehicle1.VehicleYear}");
// Console.WriteLine($"{vehicle2.VehicleName}, {vehicle2.VehicleYear}");

// Console.WriteLine($" We have {vehicles.Count} vehicles" );

// public class Vehicle(string name, string model, string year)
// {
//   public string VehicleName { get; } = name;
//   public string VehicleModel { get; } = model;
//   public string VehicleYear { get; } = year;
// }


public abstract class Vehicle
{
  public string? VehicleMake { get; set; }
  public string ?VehicleModel { get; set; }
  public string ?VehicleYear { get; set; }

  public abstract void StartEngine();

  public virtual void DisplayInfo()
  {
    Console.WriteLine($"\nVehicle Name: {VehicleMake}");

    Console.WriteLine($"Vehicle Model: {VehicleModel}");
    Console.WriteLine($"Vehicle Year: {VehicleYear}");
     
  }
}

interface IElectricVehicle
{
  string BatteryLevel { get; set; }
  void ChargeBattery();
 
}

class ElectricCar : Vehicle, IElectricVehicle
{
  public string BatteryLevel { get; set; }

  public override void StartEngine()
  {
    Console.WriteLine("Start Engine: Importedly strong\n");
  }


 public void ChargeBattery()
  {
    BatteryLevel = "100";
    Console.WriteLine("Fully charged!");
  }

  public override void DisplayInfo()
  {
    base.DisplayInfo();
    Console.WriteLine($"Battery Level: {BatteryLevel}%");
    ChargeBattery();
    
  }
  public ElectricCar(string vName, string vModel, string vYear, string batteryLevel)
  {
    VehicleMake = vName;
    VehicleModel = vModel;
    VehicleYear = vYear;
    BatteryLevel = batteryLevel;
  }
}

class GasolineTruck : Vehicle
{
  public override void StartEngine()
  {
    Console.WriteLine("Start Engine: kick-start");
  }
  

  public GasolineTruck(string vName, string vModel, string vYear)
  {
    VehicleMake = vName;
    VehicleModel = vModel;
    VehicleYear = vYear;
   
  }


}

class Program
{

  public static void Main(string[] args)
  {
    Vehicle vehicle = new ElectricCar("Ford", "Toyota", "2020", "90");
  
    vehicle.DisplayInfo();
    vehicle.StartEngine();
    vehicle.DisplayInfo();

    Vehicle gasolineTruck = new GasolineTruck("Trailer", "Gasoline", "2001");
    gasolineTruck.DisplayInfo();
    gasolineTruck.StartEngine();
  }
}