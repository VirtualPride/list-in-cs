using System;

using System.Collections.Generic;


class GFG
{

  static public string input ()
  {

    string x = Console.ReadLine ();

      return x;

  }


  public static void Main ()
  {

    LinkedList < String > my_list = new LinkedList < String > ();

    my_list.AddLast ("1");

    my_list.AddLast ("2");

    my_list.AddLast ("3");

    my_list.AddLast ("4");

    my_list.AddLast ("5");


    Console.WriteLine ("Element of list:");	//Print the list
    foreach (string str in my_list)
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nAdd First Element with:");	//Add first element
    string head = input ();

    my_list.AddFirst (head);


    Console.WriteLine ("Element of new list:");	//Print the list
    foreach (string str in my_list)
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nAdd Last Element with:");	//Add last element
    string tail = input ();

    my_list.AddLast (tail);


    Console.WriteLine ("Element of new list:");	//Print the list
    foreach (string str in my_list)
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nAdd Element after:");	//where you add it?
    string add = input ();

    LinkedListNode < String > node = my_list.Find (add);

    Console.WriteLine ("Add with:");	//add what?
    string with = input ();

    my_list.AddAfter (node, with);


    Console.WriteLine ("Element of new list:");	//Print the list
    foreach (string str in my_list)
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nDelete First:");

    Console.Read ();

    my_list.RemoveFirst ();

    foreach (string str in my_list)	//Print the list
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nDelete Last:");

    Console.Read ();

    my_list.RemoveLast ();

    foreach (string str in my_list)	//Print the list
    {

      Console.Write ("{0}   ", str);

    }

    Console.WriteLine ("\n\nChoose to delete:");

    string kill = input ();

    my_list.Remove (kill);

    foreach (string str in my_list)	//Print the list
    {

      Console.Write ("{0}   ", str);

    }
  }
}
