namespace BindingMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string Message {  get; set; }
        public string ReturnMessage { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            rotationLabel.Rotation = rotationSlider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ReturnMessage = "Wartość z entry " + Message;
            //OnPropertyChanged("ReturnMessage");
            //OnPropertyChanged(nameof(ReturnMessage));
        }
    }

}
