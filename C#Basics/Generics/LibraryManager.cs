using System;
using System.Collections.Generic;

public enum Status
{
  Available;
  Borrowed;
  Reserved;
}
public class Book
{
	public int Id { get; set; }
	public string Title { get; set; }
	public Status bookstatus { get; set; }
	public Book(int bookId, string title, Status status)
	{
		Id = bookId;
		Title = title;
		bookstatus = status;
	}
}
public class Library<T>
{
	private Dictionary<int T> items = new Dictionary<int, T>()
		public void Additem(int Id, T item)
	{
		items[Id] = item;
	}

	public T GetItem(int id)
	{
        if (items.ContainsKey(id))
        {
			return id;
        }
        //return items.ContainsKey(id) ? items[id] : default;
	}
}

public class Program
{
    public static void Main()
	{
	  Dictionary<int id, T Book> book = new()
	  {
		
	  }
	}
}

