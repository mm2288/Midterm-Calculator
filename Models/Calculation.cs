﻿using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Events;


namespace MidtermCalculator.Models
{
    public class Calculation : ICalculate
    {
        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a single operation function
        public Func<double, double, double> Operation { get; set; }



        //constructor for 3 param (Double, Double, Functi on)
        public Calculation(double a, double b, Func<double, double, double> calculation)
        {
            A = a;
            B = b;
            //this stores the operation to be performed on A and B
            Operation = calculation;
        }
        //constructor for 2 param (list, and function)
        //constructor with 0 param
        public Calculation() { }


        //This calls whatever operation was stored i.e. mult, div, add, sub and returns the answer
        public double GetResult()
        {
            return Operation(A, B);

        }


    }
}
