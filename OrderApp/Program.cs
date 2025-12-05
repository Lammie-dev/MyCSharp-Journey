using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using OrderLists;
namespace OrderLists
{
    public class OrderList
    {

        public string? OrderItems { get; set; }
        public int OrderAmount { get; set; }

    }

    public class TaskList
    {
        public string? TaskName { get; set; }
        public bool IsComplete { get; set; }

    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tasks Completed ");

            List<TaskList> taskLists = new List<TaskList>

            {

                new TaskList {TaskName = "Do the Laundry",
                    IsComplete = false },
                new TaskList {TaskName = "Go for shopping",
IsComplete = true },
new TaskList {TaskName = "Book a flight", IsComplete =true },
new TaskList {TaskName = "Online lecture", IsComplete = false}
            };

            var completed = taskLists.Where(taskList => taskList.IsComplete);
            foreach (var t in completed)
            {
                Console.WriteLine(t.TaskName);
            }

            List<OrderList> orderLists = new List<OrderList>
        {
new OrderList {OrderItems = "American Pasta", OrderAmount = 30},
new OrderList {OrderItems = "French fries & spicy Chicken", OrderAmount = 50},
new OrderList {OrderItems = "Spaghetti Bolognese", OrderAmount = 45},
new OrderList {OrderItems = "Nigerian Jollof", OrderAmount = 70},
new OrderList {OrderItems = "Family Platter", OrderAmount = 100},
new OrderList {OrderItems = "Small size Pizza", OrderAmount = 49},
new OrderList {OrderItems = "Yoghurt", OrderAmount = 20},
new OrderList {OrderItems = "Family Dessert", OrderAmount = 150},
new OrderList {OrderItems = "Spicy Croaker Fish", OrderAmount = 9},
        };
            Console.WriteLine("\nORDER LIST\n");
            Console.WriteLine($"Order Names\t\t\tOrder Amount");
            Console.WriteLine(new string('-', 60));

            foreach (var orderItem in orderLists)
            {
                Console.WriteLine($"- {orderItem.OrderItems,-25}\t\t ${orderItem.OrderAmount,0}");

            }

            var orderList = orderLists.Where(o => o.OrderAmount < 50);
            foreach (var item in orderList)
            {
                Console.WriteLine("\nOrder items below $50");
                Console.WriteLine($"-{item.OrderItems}, ${item.OrderAmount}");
            }
            var orderSkip = orderLists.SkipWhile(o => o.OrderAmount > 10);
            foreach (var item in orderSkip)
            {
                Console.WriteLine("\nOrder items greater than $10");
                Console.WriteLine($"-{item.OrderItems}, ${item.OrderAmount}");
            }
            var orderTake = orderLists.TakeWhile(o => o.OrderAmount > 50);
            foreach (var item in orderTake)
            {
                Console.WriteLine("\nOrder items greater than $50");
                Console.WriteLine($"-{item.OrderItems}, ${item.OrderAmount}");
            }
        }
    }

}
