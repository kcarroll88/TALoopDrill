using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] answers = new string[7];
        answers[0] = "john";
        answers[1] = "jason";
        answers[2] = "jeff";
        answers[3] = "jay";
        answers[4] = "julie";
        answers[5] = "jerry";

        Console.WriteLine("Please add a word.");
        string answer = Console.ReadLine();
        string.Join(answer, answers);

        foreach (string answer1 in answers)
        {
            Console.WriteLine(answers.ToString());
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

        for (int j = 0; j < cars.Count; j++)
        {
            if (car == "Toyota")
            {
                Console.WriteLine(cars.IndexOf("Toyota"));
                break;
            }
            if (car == "Mercedes")
            {
                Console.WriteLine(cars.IndexOf("Mercedes"));
                break;
            }
            if (car == "BMW")
            {
                Console.WriteLine(cars.IndexOf("BMW"));
                break;
            }
            if (car == "Honda")
            {
                Console.WriteLine(cars.IndexOf("Honda"));
                break;
            }
            else
            {
                Console.WriteLine("You did not choose one of the manufacturers on the list.");
            }
        }

        List<string> names = new List<string>();
        names.Add("John");
        names.Add("Jerry");
        names.Add("Suzan");
        names.Add("John");

        Console.WriteLine("Type a name to search for in the Names List.");
        string name = Console.ReadLine();

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == "John")
            {
                Console.WriteLine(names.IndexOf("John"));
                break;
            }
            if (names[i] == "Jerry")
            {
                Console.WriteLine(names.IndexOf("Jerry"));
                break;
            }
            if (names[i] == "Suzan")
            {
                Console.WriteLine(names.IndexOf("Suzan"));
                break;
            }
            if (names[i] == "John")
            {
                Console.WriteLine(names.IndexOf("John"));
                break;
            }
            else
            {
                Console.WriteLine("You did not choose one of the names on the list.");
                
            }

            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Chocolate");

            foreach (string iceCreams in iceCream)
            {
                if ()
                {

                }
            }

            Console.ReadLine();
        }
    }
}

