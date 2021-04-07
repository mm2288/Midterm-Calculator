using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Events
{
    public class EventAggregator
    {
        Calculator _calculator;
        
        PrintCalculation printCalc = new PrintCalculation();
        
        ConsoleManager consoleManager = new ConsoleManager();

        public EventAggregator(Calculator calculator)
        {
            _calculator = calculator;
        }

        void StoreUserInput()
        {
            consoleManager.AddGetInputEvent();
        }

        public void DisplayUserInputs()
        {
            consoleManager.PrintInput();

            consoleManager.RemoveGetInputEvent();
        }

        public void AddPrintCalcEvent()
        {
            _calculator.calculationEvent.calcComplete += printCalc.OnCalc;

        }

        public void RemovePrintCalcEvent()
        {
            _calculator.calculationEvent.calcComplete -= printCalc.OnCalc;


        }

       

    }
}
