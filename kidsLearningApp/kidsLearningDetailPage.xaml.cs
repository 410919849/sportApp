namespace kidsLearningApp;

public partial class kidsLearningDetailPage : ContentPage
{
	public kidsLearningDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
		Title = categoryName;
	}

	private void DisplayLearningResult(string categoryName)
	{
		news learningdata = new news();
		switch (categoryName) {             
		            case "胸部訓練":
		                CvKids.ItemsSource = learningdata.胸部訓練;
		                break;
		            case "手臂訓練":
		                CvKids.ItemsSource = learningdata.手臂訓練;
		                break;
		            case "腿部訓練":
		                CvKids.ItemsSource = learningdata.腿部訓練;
		                break;
		            case "背部訓練":
		                CvKids.ItemsSource = learningdata.背部訓練;
		                break;
					case "肩膀訓練":
						CvKids.ItemsSource = learningdata.肩膀訓練;
						break;
					case "其他運動新聞":
						CvKids.ItemsSource = learningdata.其他運動新聞;
						break;
		        }
	}

    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var selectedItem = e.CurrentSelection.FirstOrDefault() as LearningItem;
		await TextToSpeech.SpeakAsync(selectedItem.Name);
    }
}
