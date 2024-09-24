namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public bool IsoperationA { get; set; }
        public bool IsoperationL { get; set; }
        public bool IsoperationM { get; set; }
        public bool IsoperationD { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int firstnumber;
            int result = 0;
            if (!int.TryParse(FirstNumber, out firstnumber))
            {
                resultlabel.Text = "Niepoprawna pierwsza liczba";
                resultlabel.TextColor = Colors.Red;
                return;
            }
            if (!int.TryParse(SecondNumber, out int secondnumber))
            {
                resultlabel.Text = "Niepoprawna druga liczba";
                resultlabel.TextColor = Colors.Red;
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
            resultlabel.Text = $"Wynik operacji: {result}";
            resultlabel.TextColor = Colors.Navy;
        }
    }
}
