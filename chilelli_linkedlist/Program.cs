using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace chilelli_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            LL MyLL = new LL();
            while (running)
            {
                menuStrings();
                string uChoice = Console.ReadLine();
                tehList(uChoice);
            }
            void menuStrings()
            {
                Console.WriteLine("WELL DON'T JUST STAND THERE, CHOOSE SOMETHIN'\n");
                Console.WriteLine("1: Show Head");
                Console.WriteLine("2: Add item");
                Console.WriteLine("3: Remove Item");
                Console.WriteLine("4: Search for Item");
                Console.WriteLine("5: Print");
                Console.WriteLine("6: Exit");
            }
            void tehList(string uChoice)
            {
                switch (uChoice)
                {
                    case "1":
                        //Get head
                        if (MyLL.getFirst() == null)
                        {
                            Console.WriteLine("You've reached the Headless Horseman, cause there ain't no head here  :(\n");
                        }
                        else { Console.WriteLine(MyLL.getFirst().data); }
                        break;
                    case "2":
                        // Adds items to front or back
                        Console.WriteLine("What thingy mc doo da we addin SIR?");
                        string item = Console.ReadLine();
                        Console.WriteLine("We poppin' something on teh FRONT or nailin' it to teh BACK?\n F = FRONT & B = BACK");
                        string fORb = Console.ReadLine().ToUpper();
                        while (fORb != "F" && fORb != "B")
                        {
                            Console.WriteLine("THAT WAS NOT AN OPTION USER!\nTRY AGAIN!");
                            fORb = Console.ReadLine().ToUpper();
                        }
                        //Adds front
                        if (fORb == "F") 
                        { 
                            MyLL.addFirst(item);
                            Console.WriteLine("We popped " + item + " on the front for ya\n");
                        }
                        //Adds end
                        else 
                        { 
                            MyLL.Add(item);
                            Console.WriteLine("It's held up with glue and duct tape, but " + item + " is now on the end of the list\n");
                        }
                        break;
                    case "3":
                        //Remove item
                        Console.WriteLine("THE WRECKING CREW IS COMING TO KNOCK SOMETHIN' OFF TEH LIST, What'll it be sir?");
                        string delete = Console.ReadLine();
                        if (MyLL.Contains(delete) == null)
                        {
                            Console.WriteLine("The wrecking crew returns sad faced and empty handed as " + delete + " was not in the list\nNothing removed\n");
                        }
                        else 
                        { 
                            MyLL.Remove(delete);
                            Console.WriteLine("The wrecking crew returns with smiles as they have successfully demolished " + delete + " from teh list\n");
                        }
                        break;
                    case "4":
                        //Contains item
                        Console.WriteLine("Sherlock Holmes AT YOUR SERVICE. What be we searchin' for?");
                        string holmes = Console.ReadLine();
                        if (MyLL.Contains(holmes) == null) { Console.WriteLine("I declare this case unsolvable " + holmes + " IS NOT here\n"); }
                        else {Console.WriteLine("I do say that " + holmes + " is indeed contained within!\n");}
                        break;
                    case "5":
                        //Print all
                        
                        Console.WriteLine(MyLL.Print());
                        break;
                    case "6":
                        //Exits
                        Console.WriteLine("Goodbye :)");
                        int milisecs = 2000;
                        //This is bad way to exit I'm pretty sure, but wanted something different than usual
                        Thread.Sleep(milisecs);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Selection\n");
                        break;
                }
            }
        }
        public class Node
        {
            public string data;
            public Node next;

            public Node(string data)
            {
                this.data = data;
                next = null;
            }
        }
        public class LL
        {
            Node head;
            public Node getFirst()
            {
                if (head != null)
                {
                    return head;
                }
                else
                {
                    return null;
                }
            }
            public void addFirst(string item)
            {
                Node firstNode = new Node(item);
                firstNode.next = head;
                head = firstNode;
            }
            public Node Contains(string item)
            {
                //CONTAINS
                Node current = head;
                if (head == null) { return null; }
                while(current != null)
                {
                    if (current.data == item) { return current; }
                    if (current.next == null) { return null; }
                    current = current.next;
                }
                return null;
            }
            public void Remove(string item)
            {
                //Removes
                Node current = head;
                while(current != null)
                {
                    Node next = current.next;
                    if (current.data == item)
                    {
                        head = next;
                        break;
                    }
                    if (next.data == item)
                    {
                        current.next = next.next;
                        break;
                    }
                    current = current.next;
                }
            }
            public void Add(string item)
            {
                if (head == null)
                {
                    head = new Node(item);
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new Node(item);
                }
            }
            public string Print()
            {
                Node current = head;
                string print = "";
                if (head == null)
                {
                    return "Aye, this list appears to be empty\n";
                }
                else
                {
                    while (current != null)
                    {
                        print = print + current.data + "\n";
                        current = current.next;
                    }
                    return print;
                }
            }
        }
    }
}