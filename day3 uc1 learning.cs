// See https://aka.ms/new-console-template for more information
using System;
class program
{
    static void Main(string[] args)
    {
        int ITS_FULL_TIME = 1;

        Random random = new Random();
        //Computation;
        int empCheck = random.Next(0, 2);
        if (empCheck == ITS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console . WriteLine("Employee is present");
        }
    }

}
