namespace OwnMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public List<string> Collection { get; set; }
        public string Selected { get; set; }
        public string Selected2 { get; set; }

        public string Liczba {  get; set; }

        private string selectedMessage;
        public string SelectedMessage
        {
            get { return selectedMessage; }
            set
            {
                selectedMessage = value;
                OnPropertyChanged();
            }
        }
        public string NewFruit { get; set; }

        public MainPage()
        {
            Collection = new List<string>();
            Collection.Add("cm");
            Collection.Add("dm");
            Collection.Add("m");

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int NewLiczba;
            NewLiczba = 100;
            SelectedMessage = Liczba + " " + Selected + " = " + NewLiczba + " " + Selected2;
        }

    }

}
