// class Animal
// {
//   public virtual void animalSound()
//   {
//     Console.WriteLine("The animal made a sound");
//   }
// }
// class Pig : Animal
// {
//   public override void animalSound()
//   {
//     Console.WriteLine("The pig made a sound");
//   }



// }

// class Program
// {
//   public static void Main(string[] args)
//   {
//     Pig pig = new Pig();
//     pig.animalSound();
//     Animal animal = new Animal();
//     animal.animalSound();
//   }
// }


//ABSTRACTION

// abstract class Animal
// {
//   public abstract void animalSound();
//   public void sleep()
//   {
//     Console.WriteLine("Zzzz");
//   }
// }


// class Pig : Animal
// {
//   public void makeSound()
//   {
//     Console.WriteLine(" muzzzz");
//   }
//    public override void animalSound() {
//     Console.WriteLine("Animal do make noise");
// }
// }
// class Program
// {
//   public static void Main()
//   {
//     Pig pig = new Pig();
//     pig.animalSound();
//     pig.sleep();
//     pig.makeSound();

//   }

// }



//INTERFACE

using System.Security.Cryptography.X509Certificates;

interface IAnimal
{
  void animalSound();
  void run();
}

class Pig : IAnimal
{
  public void animalSound()
  {
    Console.WriteLine("Zzzzz");
  }

  public void run()
  {
    Console.WriteLine("slow");
  }
}
class Program
{
  public static void Main()
  {
    Pig pig = new Pig();
    pig.animalSound();
    pig.run();
  } 
}