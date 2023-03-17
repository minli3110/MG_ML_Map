namespace MG;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage =  new AppShell();

        MainPage = new NavigationPage(new MainPage());

    }

  protected override Window CreateWindow(IActivationState activationState)
       {
           var window = base.CreateWindow(activationState);

           const int newWidth = 365;
           const int newHeight = 675;

            window.Width = newWidth;
            window.Height = newHeight;
        
         return window;
     }
}
