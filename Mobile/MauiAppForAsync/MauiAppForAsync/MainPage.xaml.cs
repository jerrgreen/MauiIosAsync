using MauiAppForAsync.Services;

namespace MauiAppForAsync;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
		var service = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<IAsyncInvokerService>();

		Task.Run(async () => await service.DebugLog("test"));
    }
}

