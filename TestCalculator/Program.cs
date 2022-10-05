using System;
using System.Linq;
public class calculator
{
    public static void Main()
    {


           
        double num1;
        double num2;
        int menu;

        while (true)
        {

            Console.Write("\n\n");
            Console.Write("A menu driven program for a calculator:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");





            Console.Write("\nHere are the options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.Write("\nInput your choice :");
            menu = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {

                case 1:


                    Console.WriteLine("Enter how many numbers you like to caculate");
                    int size = int.Parse(Console.ReadLine());
                    double[] arr = new double[size];
                    Console.WriteLine("input all numbers,please type enter at the end of each number");


                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = double.Parse(Console.ReadLine());

                    }
                    if (arr.Length == 2)
                    {



                        num1 = arr.First();
                        num2 = arr.Last();

                        Console.Write("The Addition of {0}  and {1} is : {2}\n", num1, num2, Addition(num1, num2));
                    }
                    else
                    {

                        Console.WriteLine("The Addition of {0}", Addition(arr));



                    }

                    break;

                case 2:
                    
                        Console.WriteLine("Enter how many numbers you like to caculate");
                    int size2 = int.Parse(Console.ReadLine());
                    double[] arr1 = new double[size2];
                    Console.WriteLine("input all numbers,please type enter at the end of each number");


                    for (int i = 0; i < arr1.Length; i++)
                    {
                        arr1[i] = double.Parse(Console.ReadLine());

                    }
                    if (arr1.Length == 2)
                    {



                        num1 = arr1.First();
                        num2 = arr1.Last();

                        Console.Write("The Substraction of {0} and {1} is: {2}\n", num1, num2, Substraction(num1, num2));
                    }
                    else
                    {

                        Console.WriteLine("The Substraction of {0}", Substraction(arr1));


                    }
                  



                        break;

                case 3:

                    GetInputFromUser(out num1, out num2);
                    //Multiplication
                    Console.Write("The Multiplication of {0} and {1} is: {2}\n", num1, num2, Multiplication(num1, num2));


                    break;

                case 4:
                    GetInputFromUser(out num1, out num2);
                    //Division
                    Division(num1, num2);



                    Console.Write("\n");

                    break;

                case 5:
                    Console.Write("Exiting program");
                    System.Environment.Exit(0);


                    break;

                default:
                    Console.Write("Input correct option\n" + menu);


                    break;
            }
            Console.WriteLine("Any key return to the menu\n");
            Console.ReadKey();
        }
    }

    // user input
    public static void GetInputFromUser(out double num1, out double num2)
    {
        Console.WriteLine("Enter the first integer number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second integer number:");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
    public static double Addition(double num1, double num2)
    {

        return num1 + num2;

    }
    public static double Substraction(double num1, double num2)
    {


        return num1 - num2;
    }
    public static double Multiplication(double num1, double num2)
    {


        return num1 * num2;

    }
    public static double Division(double num1, double num2)
    {



        if (num2 == 0)
        {
            Console.Write("You are not allowed divide by 0 ");

        }
        else
        {

            Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);

        }
        return num1 / num2;

    }
    public static double Addition(double[] arr)
    {

        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];


        }
        return sum;
    }

    public static double Substraction(double[] arr)
    {

        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum -= arr[i];


        }
        return sum;
    }
}