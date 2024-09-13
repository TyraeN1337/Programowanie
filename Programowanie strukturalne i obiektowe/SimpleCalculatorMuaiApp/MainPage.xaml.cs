
namespace SimpleCalculatorMuaiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string strfirst = numberOEntry.Text;
            int firstnumber;
            if (!int.TryParse(strfirst, out firstnumber))
            {
                resultlabel.Text = "Niepoprawna pierwsza liczba";
                resultlabel.TextColor = Colors.Red;
                return;
            }
            if(!int.TryParse(numberSEntry.Text, out int secondnumber))
            {
                resultlabel.Text = "Niepoprawna druga liczba";
                resultlabel.TextColor = Colors.Red;
                return;
            }
            int result = 0;
            if (operationA.IsChecked)
            {
                result = firstnumber + secondnumber;
            }
            if (operationL.IsChecked)
            {
                result = firstnumber - secondnumber;
            }
            if (operationM.IsChecked)
            {
                result = firstnumber * secondnumber;
            }
            if (operationD.IsChecked)
            {
                result = firstnumber / secondnumber;
            }
            resultlabel.Text = $"Wynik operacji: {result}";
            resultlabel.TextColor = Colors.Navy;
        }
    }
     
}
