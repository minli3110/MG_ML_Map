namespace MG;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnChineseButtonClicked(object sender, EventArgs e)
    {
        // Handle the click event here
        Navigation.PushAsync(new Chinesecuisines());
    }
    private void OnMalayButtonClicked(object sender, EventArgs e)
    {
        // Add your event handler code here
        Navigation.PushAsync(new Malayscuisines());
    }

    private void OnIndianButtonClicked(object sender, EventArgs e)
    {
        // Add your event handler code here
        Navigation.PushAsync(new Indiancuisines());

    }
}
