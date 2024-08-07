﻿using System;

class Program
{
    static void Main()
    {
        Program program = new Program();
        int answer = program.Response();
        Tree(answer);
        Console.WriteLine("Congratulations you have made a christmas tree " + answer + " lines long");
    }

    static void Tree(int height)
    {
        int length = height * 2 - 1;
        int stars = 1;

        for (int i = 1; i <= height; i++)
        {
            Console.WriteLine(new string('*', stars).PadLeft((length + stars) / 2).PadRight(length));
            stars += 2;
        }

        Console.WriteLine("*".PadLeft((length + 1) / 2).PadRight(length));
    }

    public int Response()
    {
        Console.WriteLine("How big do you want your tree? (Please enter a number)");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int answer))
        {
            return answer;
        }
        else
        {
            Console.WriteLine("Please enter a number.");
            return Response();
        }
    }
}
