using System;
using System.Collections.Generic;
using System.Linq;
namespace ContactBooks
{
  class ContactBook
  {
    public string Name;
    public long Phone { get; set; }
    public string Email;
    public ContactBook(string name, long phone, string email)
    {
      Name = name;
      Phone = phone;
      Email = email;
    }
  }
  class Program
  {
    static void Main()
    {
      List<ContactBook> contactBooks = new List<ContactBook>();


      while (true)

      {

        string name;
        long phone;
        string email;




        Console.Write("Contact Name: ");
        name = Console.ReadLine();


        // System.Int64 pnum;
        // long phone;




        while (true)
        {



          Console.Write("Contact Number: ");
          string input = Console.ReadLine();

          if (long.TryParse(input, out phone) && input.Length == 10)
          {

            break;
          }
          else
          {
            Console.WriteLine("Invalid input! Enter number not more than 10 digits.");
          }

        }

        Console.Write("Email: ");
        email = Console.ReadLine();

        ContactBook contactBook = new ContactBook(name, phone, email);
        contactBooks.Add(contactBook);

        // string email;


        Console.WriteLine("Press show to view all contacts or press any key to continue. ");
        string choice = Console.ReadLine();
        if (choice != "show");
        else
        {

          //to display all contacts

          Console.WriteLine("CONTACTS LIST ");
          Console.WriteLine("\nContact name\tContact number\tContact email");
          Console.WriteLine(new string('-', 60));
          foreach (var contactBookItem in contactBooks)
          {

            Console.WriteLine($"-  {contactBookItem.Name, -10}\t {contactBookItem.Phone}\t {contactBookItem.Email}\t");
            // Console.Write($"- {phone}\t");
            // Console.Write($"- {email}\n");
          }

        }



        // //to display all contacts

        // Console.WriteLine("CONTACTS LIST ");
        // Console.WriteLine("\nContact name\t\tContact number\tContact email");
        // Console.WriteLine(new string('-', 60));
        // foreach (var contactBook in contactBooks)
        //   // {
        //   //   Console.WriteLine("item");
        //   Console.Write($"-  {name}\t\t {phone}\t {email}\t");
        // Console.Write($"- {phone}\t");
        // Console.Write($"- {email}\n");
        // }
        // ContactBook contactBook = new ContactBook(name, phone, email);
        //           contactBooks.Add(contactBook);

        // foreach (var item in contactBooks)
        // {
        //   Console.WriteLine("item");
        // }





        //  foreach (var contactBook in contactBooks)

        //             Console.WriteLine($"\n Contacts list:\n {contactBook.Name}\t{contactBook.Phone}\t{contactBook.Email}");

        // var contactBookk = contactBook.Name[name];
        // var contactBookk = contactBooks.Phone;
        // foreach (var contactBook in contactBookk)


        //  foreach (var contactBook in contactBookk)

        //   {
        //     Console.WriteLine("\nContact name\t\tContact number\tContact email");
        //     Console.WriteLine($"\n Contacts list:\n {contactBook.Name}\t{contactBook.Phone}\t{contactBook.Email}");

        //   } 



        // ContactBook contactBook = new ContactBook(name, phone, email);
        // contactBooks.Add(contactBook);



      }

    }
  }
}

// ContactBook contactBook = new ContactBook(name, phone, email);

// contactBooks.Add(contactBook);