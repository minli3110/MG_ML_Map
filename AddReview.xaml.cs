using MG.ChineseCuisines;
using MG.ViewModels;
using Microsoft.Maui.Storage;

namespace MG;


public partial class AddReview : ContentPage
{
	public AddReview()
	{
		InitializeComponent();
        
	}

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Add your event handler code here
        Navigation.PushAsync(new ChickenRice());
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        // Add your event handler code here
        Navigation.PushAsync(new ChickenRice());
    }

    private async void OnAddPhotoClicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Pick Photo",
            FileTypes = FilePickerFileType.Images
        });

        if (result == null)
            return;

        var stream = await result.OpenReadAsync();

        addPhoto.Source = ImageSource.FromStream(() => stream);
    }

    
}