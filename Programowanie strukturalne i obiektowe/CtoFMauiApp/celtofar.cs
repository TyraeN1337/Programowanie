using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoFMauiApp
{
    public class CeltoFar : BindableObject
    {
        public string Selected { get; set; }
        public List<string> Collection { get; set; }
        public string Liczba { get; set; }

        public string resultMessage;
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
        public CeltoFar()
        {
            Collection = new List<string>();
            Collection.Add("C");
            Collection.Add("Fh");
            CalculateCommand = new Command(Calculate);
        }
       
        private void Calculate()
        {
            int result = 0;
            int liczba;
            if (!int.TryParse(Liczba, out liczba))
            {
                ResultMessage = "Niepoprawna liczba";
                ColorMessage = Colors.Red;
                return;
            }
            if (Selected == "C")
            {
                result = (liczba * 9 / 5) + 32;
                ResultMessage = result + " Fh ";
                ColorMessage = Colors.Navy;
            }
            else if (Selected == "Fh")
            {
                result = (liczba - 32) * 5 / 9;
                ResultMessage = result + " C ";
                ColorMessage = Colors.Navy;
            }
        }
    }
}
