using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Security.AccessControl;
using TestCalculator;



namespace TestCalculator.Test.Unit
{
    public class Testcalculator
    {
       // private readonly Program _program = new Program();
        [Fact]
        public static void TestAddition()

        {
            int num1 = 1;

            int num2 = 2;
            
            Assert.Equal(3, calculator.Addition(num1 , num2));
    
        }
        [Fact]
        public static void TestSubstraction()

        {
            int num1 = 3;

            int num2 = 2;

            Assert.Equal(1, calculator.Substraction(num1, num2));

        }
        [Fact]
        public static void TestMultiplication()

        {
            int num1 = 1;

            int num2 = 2;

            Assert.Equal(2, calculator.Multiplication(num1, num2));

        }
        [Fact]
        public static void TestDivision()
            //
        {
            int num3 = 4;

            int num4 = 2;

            Assert.Equal(2, calculator.Division(num3, num4));

        }
        [Fact]
        public static void TestArrayAddition()

        {
             double [] numbers = new double [] { 1, 2, 3 };

            Assert.Equal(6, calculator.Addition(numbers));

        }
        [Fact]
        public static void TestArraySubstraction()

        {
            double[] numbers = new double[] { 5, 2, 1 };

            Assert.Equal(2, calculator.Substraction(numbers));

        }

        [Fact]
        public static void Exeption()

        {

            Assert.IsNotType<decimal>(calculator.Division(10, 0));

        }

    }

}