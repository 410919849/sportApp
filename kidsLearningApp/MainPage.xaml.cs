namespace kidsLearningApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            Navigation.PushAsync(new kidsLearningDetailPage(button.CommandParameter.ToString()));
        }
    }
}