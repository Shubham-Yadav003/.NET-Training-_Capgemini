// using System;
// using System.Collections.Generic;

// class Program
// {


//     public static void Main()
//     {
//         Order obj = new Order();
//         Stack<Order> st = new Stack<Order>(); // stack of type order created 

//         int orderId = int.Parse(Console.ReadLine());
//         string customerName = Console.ReadLine();
//         string item = Console.ReadLine();

//         st = obj.AddOrder(st, orderId, customerName, item);
      
//         Console.WriteLine(obj.getOrderDetail(st));

//         // to see reaming items
//         // obj.Remaining_Order(st); 

//         // remove latest
//         st = obj.RemoveOrder(st);

//         // remaining order count
//         Console.WriteLine(st.Count());


//     }

//     public class Order
//     {
//         public int OrderId { get; set; }
//         public string CustomerName { get; set; }

//         public string Item { get; set; }

//         public Stack<Order> AddOrder(Stack<Order> st, int orderId, string customerName, string item)
//         {
//             Order order = new Order();
//             order.OrderId = orderId;
//             order.CustomerName = customerName;
//             order.Item = item;

//             st.Push(order);
//             return st;
//         }

//         public string getOrderDetail(Stack<Order> st)
//         {
//             if (st.Count == 0)
//             {
//                 return "No orders";
//             }

//             Order order = st.Peek(); // top elem

//             return order.OrderId + " " + order.CustomerName + " " + order.Item;
//         }

//         public void Remaining_Order(Stack<Order> st){
//             Console.WriteLine("Remaining Items:");
//             foreach(Order o in st){
//                 Console.WriteLine(o.OrderId + " " + o.CustomerName + " " + o.Item);
//             }
//         }

//         public Stack<Order> RemoveOrder(Stack<Order> st)
//         {
//             if (st.Count > 0)
//             {
//                 st.Pop(); // remove top
//             }
//             return st;
//         }
//     }

// }


//********************************************************************************************//
using System;

public class Program
{
    public static void MoveZerosToEnd(int[] arr)
    {
        int i = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] != 0)
            {
                arr[i] = arr[j];
                i++;
            }
        }

        for (int k = i; k < arr.Length; k++)
        {
            arr[k] = 0;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

       
        MoveZerosToEnd(arr);

        Console.WriteLine("Array after moving zeros:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
