using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMauiApp
{
    public class CalculatorViewModel : BindableObject
    {
        private string calculatingResult;
        public string CalculatingResult
        {
            get { return calculatingResult; }
            set { calculatingResult = value; OnPropertyChanged(); }
        }
        private Command numberCommand;

        public Command NumberCommand
        {
            get
            {
                if (numberCommand == null)
                    numberCommand = new Command<string>((string number) =>
                    {
                        if (ifOperationExecute == false)
                            CalculatingResult = CalculatingResult + number;
                        else
                        {
                            CalculatingResult = number;
                            ifOperationExecute = false;
                        }
                    });
                return numberCommand;
            }
            set { numberCommand = value; }
        }

        private Command operationCommand;

        public Command OperationCommand
        {
            get
            {
                if (operationCommand == null)
                    operationCommand = new Command<string>((string operatorSign) =>
                    {
                        if (ifOperationExecute)
                            return;
                        int firstNumber = prevNumber;
                        int secondNumber = int.Parse(calculatingResult);
                        CalculatingResult = GetOpResult(prevOperatorSign,firstNumber,secondNumber).ToString();
                        prevOperatorSign = operatorSign;
                        ifOperationExecute = true;
                    });
                return operationCommand;
            }
            set { operationCommand = value; }
        }
        private bool ifOperationExecute = false;
        private string prevOperatorSign;
        private int prevNumber; 
        int GetOpResult(string operatorSign, int firstNumber, int secondNumber)
        {
            int result = 0;
            switch(operatorSign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
        public CalculatorViewModel()
        {

        }
    }
}
