using System;
using System.Collections.Generic;
using System.Linq;
namespace LibraryManagement
{
  class Book
  {
    public  string Title{ get; set; }
    public  string Author { get; set; }
    public string ISBN{ get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author, string isbn)
    {
      Title = title;
      Author = author;
      ISBN = isbn;
      IsBorrowed = false;
    }

   
    public void BorrowedBook() { IsBorrowed = true; }
    public void ReturnBook()
    {
     IsBorrowed = false;

    }

    public void DisplayInfo()
    {
      
      Console.WriteLine($"\nBook Title: {Title}");
      Console.WriteLine($"Book Author: {Author}");
      Console.WriteLine($"Book ISBN: {ISBN}");
      Console.WriteLine($"Book Status: {(IsBorrowed? "Book is not Availabile" :"Book is Availabile.\n" )}");

    }
  }


  class LibraryMember
  {
    public string Name { get; set; }
    public int MemberId { get; set; }


    public List<Book> BorrowedBooks { get; set; }
    public LibraryMember(string memberName, int memberId)
    {
      Name = memberName;
      MemberId = memberId;
      BorrowedBooks = new List<Book>();
    }

    public void Borrow(Book book)
    {
      if (!book.IsBorrowed)
      {
        book.BorrowedBook();
        BorrowedBooks.Add(book);
      }
      else
      {
        Console.WriteLine(new string('-', 60));
        Console.WriteLine($"\nHello {Name}, {book.Title} is already Borrowed.\n");
        Console.WriteLine(new string('-', 60));
       }
      
    }
    public void Return(Book book)
    {
      if (BorrowedBooks.Contains(book))
      {
        book.ReturnBook();
        BorrowedBooks.Remove(book);
        Console.WriteLine($"{Name} returned '{book.Title}' written by {book.Author} on 12-6-2025.");
      }

      else
      {
        Console.WriteLine($"You did not borrow {book.Title}");
      }
     
    }
    public void ShowBorrowedBooks()
    {
      Console.WriteLine($"\nList of books borrowed by {Name}");
      Console.WriteLine(new string('-', 60));
      if (BorrowedBooks.Count == 0)
      {
        Console.WriteLine($"No books borrowed by {Name}");
      
      } 
      else
      {
        foreach (var book in BorrowedBooks)
        {
          book.DisplayInfo();
        }
      }
    }
  }



  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("\nList of available books and their status.");
      Console.WriteLine("------------------------------");

      Book TheReturnOfTheSlaveBoy = new Book(

              "The Return of the slave boy",
              "Alade Akinmonrin",
              "ISBN-13105"

       );
      TheReturnOfTheSlaveBoy.DisplayInfo();

      Book WomenOfOwu = new Book(
        "Women of Owu",
        "Wole Soyinka",
        "London-23432IBSN"
      );
      WomenOfOwu.DisplayInfo();

      Book TaleOfTheLastKingdom = new Book(
        "Tale of the last Kingdom",
        "Aminat Sofeiko",
        "Saudi-13467ISBN"
      );
      TaleOfTheLastKingdom.DisplayInfo();




      LibraryMember member1 = new LibraryMember(
        "Gabriel Odusanya ",
        109

);
      // List<Book> BorrowedBooks = new List<Book>(); 

      // BorrowedBooks.Add(TaleOfTheLastKingdom);
      // BorrowedBooks.Add(WomenOfOwu);
      member1.Borrow(TaleOfTheLastKingdom);
      member1.Borrow(WomenOfOwu);
      member1.ShowBorrowedBooks();

      LibraryMember member2 = new LibraryMember(
        "Maria Akapo",
        102
);
      member2.Borrow(TaleOfTheLastKingdom);
      member1.Return(WomenOfOwu);
      member1.ShowBorrowedBooks();





      Library librarySystem = new Library();
      librarySystem.AddBook(new Book("A Crocordile Tear", "Alabi Pomolekun", "ISBN4507"));

      librarySystem.AddBook(new Book("Woman in Her Prime", "Francisca Onome", "ISBN4510"));

      librarySystem.RegisterMember(new LibraryMember("Halimah Adunbarin", 111));

      librarySystem.RegisterMember(new LibraryMember("Moses Israel", 112));


      librarySystem.ListAllMembers();
      Console.WriteLine($"=>{member1.Name} ID{member1.MemberId}");
      Console.WriteLine($"=>{member2.Name} ID{member2.MemberId}");
      librarySystem.ListAvailableBooks();
      TaleOfTheLastKingdom.DisplayInfo();
      WomenOfOwu.DisplayInfo();
      TheReturnOfTheSlaveBoy.DisplayInfo();
      
       
    }



    class Library
    {
      public List<Book> Books { get; set; }
      public List<LibraryMember> Members { get; set; }
      public Library()
      {
        Books = new List<Book>();
        Members = new List<LibraryMember>();
      }

      public void AddBook(Book book)
      {
        Books.Add(book);
      }

      public void RegisterMember(LibraryMember member)
      {
        Members.Add(member);
      }

      public void ListAvailableBooks()
      {
        Console.WriteLine("\n-->List of All books-->");

        foreach (var book in Books)
        {

          book.DisplayInfo();
        }
      }
      
      public void ListAllMembers()
      {
        Console.WriteLine("\n-->List of Registered Members-->");
        foreach (var member in Members)
        {
          Console.WriteLine($"=>{member.Name}  ID{member.MemberId}");
          
        }
      }
}

  }
}