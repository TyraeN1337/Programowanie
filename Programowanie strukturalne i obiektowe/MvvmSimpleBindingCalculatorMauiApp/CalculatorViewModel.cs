using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSimpleBindingCalculatorMauiApp
{
    public class CalculatorViewModel : BindableObject
    {
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public bool IsoperationA { get; set; }
        public bool IsoperationL { get; set; }
        public bool IsoperationM { get; set; }
        public bool IsoperationD { get; set; }

        private string resultMessage;

        public string ResultMessage
        {
            get { return resultMessage; }
            set { resultMessage = value; OnPropertyChanged(); }
        }
        private Color colorMessage;
        public Color ColorMessage
        {
            get { return colorMessage; }
            set { colorMessage = value; OnPropertyChanged(); }
        }
        private Command calculateCommand;
        public Command CalculateCommand
        {
            get { return calculateCommand; }
            set { calculateCommand = value; OnPropertyChanged(); }
        }
        public CalculatorViewModel()
        {
            CalculateCommand = new Command(Calculate);
        }
        private void Calculate()
        {
            int firstnumber;
            int result = 0;
            if (!int.TryParse(FirstNumber, out firstnumber))
            {
                ResultMessage = "Niepoprawna pierwsza liczba";
                ColorMessage = Colors.Red;
                return;
            }
            if (!int.TryParse(SecondNumber, out int secondnumber))
            {
                ResultMessage = "Niepoprawna druga liczba";
                ColorMessage = Colors.Red;
                return;
            }
            else if (IsoperationA)
            {
                result = firstnumber + secondnumber;
            }
            else if (IsoperationL)
            {
                result = firstnumber - secondnumber;
            }
            else if (IsoperationM)
            {
                result = firstnumber * secondnumber;
            }
            else if (IsoperationD)
            {
                result = firstnumber / secondnumber;
            }
            ResultMessage = $"Wynik operacji: {result}";
            ColorMessage = Colors.Navy;
        }
    }
    
} 
