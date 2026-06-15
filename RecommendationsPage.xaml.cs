namespace BMI_Calculator_Mobile_App;

public partial class RecommendationsPage : ContentPage
{
	public RecommendationsPage(String rec)
	{
		InitializeComponent();
        recommendationsLabel.Text = rec;
	}
	private void recBackBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
	private void recHomeBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}