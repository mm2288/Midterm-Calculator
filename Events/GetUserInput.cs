using System;
namespace MidtermCalculator.Events
{
    public class GetUserInput : EventArgs
    {
        public double UserDigitInput { get; set; }
        public Func<double, double, double> UserOpInput { get; set; }
        public string UserMenuInput { get; set; }
    }
}
