Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.WriteLine($"{Environment.NewLine}How are you doing today? {name}");
Console.ReadKey(true);

// Console.WriteLine("How are you doing today?");
// var = Console.ReadLine();
