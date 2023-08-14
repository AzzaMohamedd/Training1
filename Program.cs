using System;

namespace Training1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region multiplication table

            //Console.WriteLine("Enter Number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Then, the multiplication table for {number} is :");

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {number*i}");
            //}

            #endregion



            #region triangle type

            //Console.WriteLine("Enter the three sides of the trianle:");
            //int[] arr = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Side {i+1}:");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}
            //int counter = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (arr[i]==arr[j])
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}
            //if (counter ==0)
            //{
            //    Console.WriteLine("Scalene Triangle (has no equal sides)");
            //}
            //else if (counter == 2)
            //{
            //    Console.WriteLine("Isoceles Triangle (has two equal sides)");
            //}
            //else
            //{
            //    Console.WriteLine("Equilateral Triangle (has three equal sides)");
            //}

            #endregion



            #region array of names

            //Console.WriteLine("Enter the number of names you need: ");
            //int num = int.Parse(Console.ReadLine());
            //string[] arr = new string[num];

            //Console.WriteLine($"Enter the {num} names: ");

            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Name{i+1}: ");
            //    arr[i] = Console.ReadLine();
            //}

            //Console.Write("Enter the name you choose:");
            //string name = Console.ReadLine();

            //for (int i = 0; i < num; i++)
            //{
            //    if (arr[i].Equals(name))
            //    {
            //        Console.WriteLine("This name is already exist");
            //        break;
            //    }
            //    else if (i==num-1)
            //    {
            //        Console.WriteLine("This name isn't exist , please try again...");
            //    }
            //}

            #endregion



            #region array of numbers

            //Console.WriteLine("Enter the number of numbers you need: ");
            //int num = int.Parse(Console.ReadLine());
            //int[] arr = new int[num];

            //Console.WriteLine($"Enter the {num} numbers: ");

            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Number{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i]; j++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            #endregion



            #region number or letter

            //Console.WriteLine("Enter 5 Sequences of Numbers:");
            //string[] arr = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Sequence{i + 1}: ");
            //    arr[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    string seq="";
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        char letter = arr[i][j];
            //        while (char.IsLetter(letter))
            //        {
            //            Console.WriteLine($"The {letter} is wrong , change it !! ");
            //            letter = char.Parse(Console.ReadLine());
            //        }
            //        seq += letter;
            //    }
            //    arr[i] = seq;
            //    Console.WriteLine($"The Sequence is {seq}");
            //}

            #endregion

        }
    }
}
