
namespace QuizMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private string questionText;

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; OnPropertyChanged(); }
        }
        private string correctAnswer;

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; OnPropertyChanged(); }
        }
        private string answer1;

        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; OnPropertyChanged(); }
        }

        private string answer2;

        public string Answer2
        {
            get { return answer2; }
            set { answer2= value; OnPropertyChanged(); }
        }
        private string answer3;

        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; OnPropertyChanged(); }
        }
        private string answer4;

        public string Answer4
        {
            get { return answer4; }
            set { answer4 = value; OnPropertyChanged(); }
        }
        public bool isChecked { get; internal set; }

        public string result { get; set; }
        public string Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }
        private void PreviousQ(object sender, EventArgs e)
        {
            QuestionText = "Czym jest if";
            CorrectAnswer = "pętlą";
            Answer1 = "pętlą";
            Answer2 = "na pewno nie pętlą";
            Answer3 = "pewno nie pętlą";
            Answer4 = "nie pętlą";

        }
        private void NextQ(object sender, EventArgs e)
        {
            QuestionText = "Ile mandarynek";
            CorrectAnswer = "300";
            Answer1 = "0";
            Answer2 = "30";
            Answer3 = "300";
            Answer4 = "60";
        }
        private void Checked(object sender, EventArgs e)
        {

        }
        private void Reset(object sender, EventArgs e)
        {
            int wynik = 0;
            Result = "Twój wynik to " + wynik + "/2";
        }
    }

}
