// Created by: Venika Sem
// Created on: Mar 2022
//
// This program finds the area of a trapezoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a trapezoid
        double aBaseOfTrapezoid;
        double bBaseOfTrapezoid;
        double heightOfTrapezoid;
        double area;

        // input
        Console.WriteLine("This program calculates the area of a trapezoid.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: A = [(a + b) / 2] x h");
        Console.WriteLine("");
        Console.WriteLine("Please enter the measurements (cm).");

        Console.WriteLine("");
        Console.Write("Input the measurement for base a: ");
        aBaseOfTrapezoid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for base b: ");
        bBaseOfTrapezoid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the height: ");
        heightOfTrapezoid = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        area = ((aBaseOfTrapezoid + bBaseOfTrapezoid) / 2) * heightOfTrapezoid;

        // output
        Console.WriteLine("The area of the trapezoid is: " + area.ToString("0.00") + " " + "cm².");

        Console.WriteLine("\nDone.");
    }
}