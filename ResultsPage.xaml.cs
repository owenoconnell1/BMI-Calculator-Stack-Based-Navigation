namespace BMI_Calculator_Mobile_App;

public partial class ResultsPage : ContentPage
{
	String recommendations;
	public ResultsPage(String result, String rec)
	{
		InitializeComponent();
		resultsLabel.Text = result;
		recommendations = rec;
	}

	private void resultsBackBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

	private async void recBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new RecommendationsPage(recommendations));
	}
}