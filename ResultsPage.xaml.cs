namespace BMI_Calculator_Mobile_App;

public partial class ResultsPage : ContentPage
{
	public ResultsPage(String result)
	{
		InitializeComponent();
		resultsLabel.Text = result;
	}
}