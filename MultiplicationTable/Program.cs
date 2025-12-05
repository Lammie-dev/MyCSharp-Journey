
Console.WriteLine("Hello!");
Console.WriteLine("Enter the multiplication you want learn today!");
int response = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Where would you like to stop? For example: 2*12, 2*20 etc...");
int input = Convert.ToInt32(Console.ReadLine());

int multiply = 0;

while (true)
{
  //  if (response == 2 && input ==12)
  // {
  //     Console.WriteLine($"{multiply}");
  // } 


  for (int m = 1; m <=input; m++)
  {
    // Console.WriteLine(response * m);
    multiply = response * m;
    Console.WriteLine($"{response} * {m} = {multiply}");
  }
  break;
}

