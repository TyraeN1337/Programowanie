using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMauiApp
{
    public class Throw : BindableObject
    {
        public string Cube;
        private string resultMessage1;

        public string ResultMessage1
        {
            get { return resultMessage1; }
            set { resultMessage1 = value; OnPropertyChanged(); }
        }
        private string resultMessage2;

        public string ResultMessage2
        {
            get { return resultMessage2; }
            set { resultMessage2 = value; OnPropertyChanged(); }
        }
        private Command losCommand;
        public Command LosCommand
        {
            get { return losCommand; }
            set { losCommand = value; OnPropertyChanged(); }
        }
        private Command resetCommand;
        public Command ResetCommand
        {
            get { return resetCommand; }
            set { resetCommand = value; OnPropertyChanged(); }
        }
        private Command changeCommand;
        public Command ChangeCommand
        {
            get { return changeCommand; }
            set { changeCommand = value; OnPropertyChanged(); }
        }

        public Throw()
        {
            ResetCommand = new Command(Reset);
            LosCommand = new Command(Los);
            ChangeCommand = new Command(Change);
        }

        private void Los()
        {
            int total = 0;
            int onetime = 0;
            for (int i = 0; i < 3;)
            {
                onetime++;
                total++;
            }
            ResultMessage1 = "Wynik tego losowania: " + onetime;
            ResultMessage2 = "Wynik gry: " + total;
        }
        private void Reset()
        {
            int total = 0;
            int onetime = 0;
            ResultMessage1 = "Wynik tego losowania: " + onetime;
            ResultMessage2 = "Wynik gry: " + total;
        }
        public Tab nr = new Tab();
        private void Change(Tab int nr[6],)
        {
           Image cube = new Image { Source = "k"+ Random(nr[6]) +".jpg" };
        }
    }
}
