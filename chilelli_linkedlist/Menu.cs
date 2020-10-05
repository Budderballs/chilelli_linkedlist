//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace chilelli_linkedlist
//{
//    class Menu
//    {
//        public static void menuStrings()
//        {
//            Console.WriteLine("1: List all Items");
//            Console.WriteLine("2: Show Head");
//            Console.WriteLine("3: Add item");
//            Console.WriteLine("4: Remove Item");
//            Console.WriteLine("5: Search for Item");
//            Console.WriteLine("6: Print");
//            Console.WriteLine("7: Exit");
//        }

//        public static void tehList(string uChoice)
//        {
//            LL MyLL = new LL();
//            switch (uChoice)
//            {
//                case "1":

//                    MyLL.getFirst();
//                    Console.WriteLine("Case 1 works");
                    
//                    break;
//                case "2":

//                    Console.WriteLine("Case 2 works");
//                    break;
//                case "3":

//                    Console.WriteLine("Case 3 works");
//                    break;
//                case "4":

//                    Console.WriteLine("Case 4 works");
//                    break;
//                case "5":

//                    Console.WriteLine("Case 5 works");
//                    break;
//                case "6":

//                    Console.WriteLine("Case 6 works");
//                    break;
//                case "7":

//                    Console.WriteLine("Goodbye :)");
//                    int milisecs = 2000;
//                    Thread.Sleep(milisecs);
//                    Environment.Exit(0);
//                    break;

//                default:
//                    Console.WriteLine("Invalid Selection");
//                    break;
//            }
//        }
//    }
//}
