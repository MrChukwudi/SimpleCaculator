using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Instanciate Calculator Engine:
			CalculatorEngine engine = new CalculatorEngine();

			//Instanciate Number Copnverter:
			InputConverter converter = new InputConverter();

            //Collect Inputs from User:
            Console.WriteLine("Input your first Number");
			double firstNum;
			firstNum = converter.ConvertToNumber(Console.ReadLine());

			Console.WriteLine("Input your Second Number");
			double secondNum;
			secondNum = converter.ConvertToNumber(Console.ReadLine());


			Console.WriteLine("Input your Operator");
			string myOperator = Console.ReadLine();

			//Deciding the Operation by the Operator type:
			switch(myOperator)
			{
				case "+":
					Console.WriteLine(engine.Add(firstNum, secondNum));
					break;

				case "-":
					Console.WriteLine(engine.Subtract(firstNum, secondNum));
					break;

				case "*":
					Console.WriteLine(engine.Multiply(firstNum, secondNum));
					break;

				case "/":
					Console.WriteLine(engine.Divide(firstNum, secondNum));
					break;

				default:
                    Console.WriteLine("You didn not enter a Valid operator.");
                    break;

			}
        }
	}
}
