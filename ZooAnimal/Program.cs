

abstract class Animal
{
  public string Name { get; set; }
    public int Age { get; set; }

  public abstract void MakeSound();
  public void Sleep()
  {
    Console.WriteLine($"{Name} loves to sleep");
  }
  
    public Animal(string name, int age) 
  {
    Name = name;
    Age = age;
  
  }

 }
 
 interface ICarnivore
{
  void Hunt();
}

 interface IHerbivore
 {
  void Graze();
 }
class Lion : Animal, ICarnivore
{
  public Lion(string name, int age) : base(name, age)
  {
    Name = name;
    Age = age;
  
  }

  public void Hunt()
  {
    Console.WriteLine($"{Name} is a wild animal.");
    Console.WriteLine("It hunt its prey");
  }

  public override void MakeSound()
  {
    Console.WriteLine($"{Name} roars wildly");
  }
  
 
}

class Elephant : Animal, IHerbivore
{
  public Elephant(string name, int age) : base(name, age)
  {
    Name = name;
    Age = age;
  }

  public void Graze()
  {
    Console.WriteLine("It feeds on grass");
  }
  public override void MakeSound()
  {
    Console.WriteLine("It makes a loud trumpet sound");
  }
}
class Bear : Animal, ICarnivore, IHerbivore
{
  public Bear(string name, int age) : base(name, age)
  {
    Name = name;
    Age = age;
  }

  public void Hunt()
  {
   Console.WriteLine("It hunts fish and small animals");
  }
  public void Graze()
  {
    Console.WriteLine($"{Name} also eats grass and berries");
  }

  public override void MakeSound()
  {
    Console.WriteLine("It growls wildly");
  }
}

class Zoo
{
  public List<Animal> Animals { get; set; }
  public Zoo()
  {
    Animals = new List<Animal>();
  }
  public void AddAnimal(Animal animal)
  {
    Animals.Add(animal);
  }
  public void SimulateDay()
  {
    Console.WriteLine("\nMonday at the Zoo:");

    foreach (var animal in Animals)
    {
      Console.WriteLine($"\n{animal.Name} is {animal.Age}years old");
      animal.MakeSound();
      animal.Sleep();

      if (animal is ICarnivore carnivore)
      {
        carnivore.Hunt();
      }

      if (animal is IHerbivore herbivore)
      {
        herbivore.Graze();
      }
    }
  }


  class Program
  {
    public static void Main(string[] args)
    {
      Zoo zooAnimals = new Zoo();
      zooAnimals.AddAnimal(new Lion("Baby lion", 6));
     
      zooAnimals.AddAnimal(new Elephant("Baby elephant", 12));
      zooAnimals.AddAnimal(new Bear("Baby Dumbo", 8));
      zooAnimals.AddAnimal(new Bear("Baby Bear", 2));

      zooAnimals.SimulateDay();

      
    }
  }
}

 
 


 