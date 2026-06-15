namespace BMI_Calculator_Mobile_App
{
    public partial class MainPage : ContentPage
    {
        bool maleSelected = false;
        bool femaleSelected = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void heightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            heightLabel.Text = ((int)e.NewValue) + "in";
        }
        private void weightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            weightLabel.Text = ((int)e.NewValue) + "lbs";
        }
        private void maleTap_Tapped(object sender, EventArgs e) {
            maleSelected = true;
            femaleSelected = false;
            femaleBorder.Stroke = Colors.Transparent;
            maleBorder.Stroke = Colors.Blue;
        }
        private void femaleTap_Tapped(object sender, EventArgs e){
            maleSelected = false;
            femaleSelected = true;
            maleBorder.Stroke = Colors.Transparent;
            femaleBorder.Stroke = Colors.Pink;
        }

        private async void calculateBtn_Clicked(object sender, EventArgs e)
        {
            double bmi = (weightSlider.Value * 703) / (heightSlider.Value * heightSlider.Value);
            String bmiString = bmi.ToString("0.00");
            if (maleSelected)
            {
                if (bmi < 18.5)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Male\nBMI: " + bmiString + "\nHealth Satus: Underweight", "Reccomendations:\n  -Increase calorie intake with nutrient rich foods (e.g., nuts, lean, protein, whole grains)\n  -Incorporate strength training to build muscle mass.\nConsult a nutritionisit if needed"));
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Male\nBMI: " + bmiString + "\nHealth Satus: Normal Weight", "Reccomendations:\n  -Maintain a balanced diet with proteins, healthy fats, and fiber.\n  -Stay physically active with at least 150 minutes of exercise per week.\nKeep regular check-ups to monitor overall health."));
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Male\nBMI: " + bmiString + "\nHealth Satus: Overweight", "Reccomendations:\n  -Reduce processed foods and focus on portion control.\n  -Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training.\nDrink plenty of water and track your progress."));
                }
                else
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Male\nBMI: " + bmiString + "\nHealth Satus: Obeese", "Reccomendations:\n  -Consult a doctor for personalized guidance.Start with low-impact exercises (e.g., walking, cycling).\n  -Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.\nAvoid sugary drinks and maintain a consistent sleep schedule."));
                }
            }
            else if (femaleSelected)
            {
                if (bmi < 18)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Female\nBMI: " + bmiString + "\nHealth S   atus: Underweight", "Reccomendations:\n  -Increase calorie intake with nutrient rich foods (e.g., nuts, lean, protein, whole grains)\n  -Incorporate strength training to build muscle mass.\nConsult a nutritionisit if needed"));
                }
                else if (bmi >= 18 && bmi < 24)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Female\nBMI: " + bmiString + "\nHealth Satus: Normal Weight", "Reccomendations:\n  -Maintain a balanced diet with proteins, healthy fats, and fiber.\n  -Stay physically active with at least 150 minutes of exercise per week.\nKeep regular check-ups to monitor overall health."));
                }
                else if (bmi >= 24 && bmi < 29)
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Female\nBMI: " + bmiString + "\nHealth Satus: Overweight", "Reccomendations:\n  -Reduce processed foods and focus on portion control.\n  -Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training.\nDrink plenty of water and track your progress."));
                }
                else
                {
                    await Navigation.PushAsync(new ResultsPage("Gender: Female\nBMI: " + bmiString + "\nHealth Satus: Obeese", "Reccomendations:\n  -Consult a doctor for personalized guidance.Start with low-impact exercises (e.g., walking, cycling).\n  -Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.\nAvoid sugary drinks and maintain a consistent sleep schedule."));
                }
            }
            else
            {
                 await DisplayAlert("Error", "Select a gender", "OK");
            }
        }
    }
}
