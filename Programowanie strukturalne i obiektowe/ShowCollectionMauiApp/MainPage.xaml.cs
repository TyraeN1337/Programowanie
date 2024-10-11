namespace ShowCollectionMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public List<string> FruitsCollection { get; set; }
        public string SelectedFruit { get; set; }

        private string selectedFruitMessage;
        public string SelectedFruitMessage
        {
            get { return selectedFruitMessage; }
            set
            {
                selectedFruitMessage = value;
                OnPropertyChanged();
            }
        }
        public string NewFruit { get; set; }

        public MainPage()
        {
            FruitsCollection = new List<string>();
            FruitsCollection.Add("Banan");
            FruitsCollection.Add("Jabłko");
            FruitsCollection.Add("Mandarynka");

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SelectedFruitMessage = "Wybrano owoc " + SelectedFruit;
        }
        private void Button_Clicked_NewFruit(object sender, EventArgs e)
        {
            FruitsCollection = new List<string>(FruitsCollection);
            FruitsCollection.Add(NewFruit);
            OnPropertyChanged("FruitsCollection");
        }
    }

}
