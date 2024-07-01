using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
	internal class CalculatorEngine
	{
		//Method to Perform Addition
		public double Add(double firstNumber, double secondNumber ) 
		{
			try
			{
				double result;
				if(!double.IsNaN(firstNumber) && !double.IsNaN(secondNumber))
				{
					throw new ArgumentException("To perform the addition operation, you need a valid Number!");
				}
				result = firstNumber + secondNumber;

				return result;
			}catch(Exception ex)
			{
                Console.WriteLine("The problem is: {0}", ex.Message);
				return 0;
			}
		}

		//Method to perform Subtraction:
		public double Subtract(double firstNumber, double secondNumber)
		{
			try
			{
				double result;
				if (!double.IsNaN(firstNumber) && !double.IsNaN(secondNumber))
				{
					throw new ArgumentException("To perform the addition operation, you need a valid Number!");
				}
				result = firstNumber - secondNumber;

				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine("The problem is: {0}", ex.Message);
				return 0;
			}
		}


		//Method to perform Division:
		public double Divide(double firstNumber, double secondNumber)
		{
			try
			{
				double result;
				if (!double.IsNaN(firstNumber) && !double.IsNaN(secondNumber))
				{
					throw new ArgumentException("To perform the addition operation, you need a valid Number!");
				}
				result = firstNumber / secondNumber;

				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine("The problem is: {0}", ex.Message);
				return 0;
			}
		}


		//Method to perform Multiplication:
		public double Multiply(double firstNumber, double secondNumber)
		{
			try
			{
				double result;
				if (!double.IsNaN(firstNumber) && !double.IsNaN(secondNumber))
				{
					throw new ArgumentException("To perform the addition operation, you need a valid Number!");
				}
				result = firstNumber * secondNumber;

				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine("The problem is: {0}", ex.Message);
				return 0;
			}
		}

	}
}
