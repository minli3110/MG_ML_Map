using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;
using MG.ViewModels;
//using Syncfusion.Maui.ListView.Hosting;

namespace MG;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			//.ConfigureSyncfusionListView()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Inter-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("Inter-Semibold.ttf", "OpenSansSemibold");
			})
        .UseMauiMaps();

        //View Review
        builder.Services.AddSingleton<AddReview>();


		//View Models
		builder.Services.AddSingleton<ReviewViewModel>();

		
        return builder.Build();
	}
}

