using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] answers = new string[] { "john", "jason", "jeff", "jay", "julie", "jerry" };
        Console.WriteLine("Please add a word.");
        string userInput = Console.ReadLine();

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i] = answers[i] + " " + userInput;
        }

        foreach (string answer1 in answers)
        {
            Console.WriteLine(answer1.ToString());
        }

        //Console.WriteLine("Give me a number.");
        //int num = Convert.ToInt32(Console.ReadLine());

        //while (num >= 0)
        //{
        //    Console.WriteLine("Have a good day :) ");
        //}

        Console.WriteLine("Give me a number.");
        int num1 = Convert.ToInt32(Console.ReadLine());

        while (num1 >= 0)
        {
            Console.WriteLine("Have a good day.");
            break;
        }

        Console.WriteLine("Give me another number.");
        int num2 = Convert.ToInt32(Console.ReadLine());

        while (num2 < 30)
        {
            Console.WriteLine("Your number is less than 30.");
            break;
        }

        Console.WriteLine("How about another number.");
        int num3 = Convert.ToInt32(Console.ReadLine());

        while (num3 <= 50)
        {
            Console.WriteLine("Your number is less than or equal to 50.");
            break;
        }

        List<string> cars = new List<string>();
        cars.Add("Toyota");
        cars.Add("Mercedes");
        cars.Add("BMW");
        cars.Add("Honda");

        Console.WriteLine("Choose a car manufacturers to search for in the list.");
        string car = Console.ReadLine();

        switch (car)
        {
            case "Toyota":
                Console.WriteLine(cars.IndexOf("Toyota"));
                break;
            case "Mercedes":
                Console.WriteLine(cars.IndexOf("Mercedes"));
                break;
            case "BMW":
                Console.WriteLine(cars.IndexOf("BMW"));
                break;
            case "Honda":
                Console.WriteLine(cars.IndexOf("Honda"));
                break;
            default:
                Console.WriteLine("You didn't choose a car on the list.");
                break;
        }

        List<string> names = new List<string>();
        names.Add("John");
        names.Add("Jerry");
        names.Add("Suzan");
        names.Add("John");

        Console.WriteLine("Type a name to search for in the Names List.");
        string inputName = Console.ReadLine();

        for (int j = 0; j < names.Count; j++)
        {
            if (inputName == names.ElementAt(j))
            {
                Console.WriteLine(j);                
            }
            else
            {
                Console.WriteLine("You did not choose a name from the list.");
                break;
            }
        }

        List<string> iceCream = new List<string>();
        List<string> duplicate = new List<string>();
        iceCream.Add("Vanilla");
        iceCream.Add("Chocolate");
        iceCream.Add("Strawberry");
        iceCream.Add("Chocolate");

        foreach (string iceCreams in iceCream)
        {
            if (iceCreams.Contains("Chocolate"))
            {
                duplicate.Add(iceCreams);
                Console.WriteLine(iceCreams + " Is a duplicate");
            }
            else
            {
                Console.WriteLine(iceCreams + " Is not a duplicate");
            }
        }
        Console.ReadLine();
    }
}

//1. Create a one-dimensional Array of strings.Ask the user to input some text. Create a loop that goes 
//    through each string in the Array, adding the user’s text to the string. Then create a loop that 
//    prints off each string in the Array on a separate line.

//2. Create an infinite loop.

//3. Fix the infinite loop so it will execute.

//4. Create a loop where the comparison used to determine whether to continue iterating the loop is a 
//    “<” operator.

//5. Create a loop where the comparison used to determine whether to continue iterating the loop is a 
//    “<=” operator.

//6. Create a List of strings where each item in the list is unique.Ask the user to select text to 
//    search for in the List. Create a loop that iterates through the loop and then displays the index 
//    of the array that contains matching text on the screen.

//7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

//8. Add code to that above loop that stops it from executing once a match has been found.

//9. Create a List of strings that has at least two identical strings in the List. Ask the user to select
//   text to search for in the List. Create a loop that iterates through the loop and then displays the 
//   indices of the array that contain matching text on the screen.

//10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

//11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop 
//    that evaluates each item in the list, and displays a message showing the string and whether or not 
//    it has already appeared in the list.

