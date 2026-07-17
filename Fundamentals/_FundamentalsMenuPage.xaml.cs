namespace MyMauiApp.Fundamentals;

public partial class _FundamentalsMenuPage : ContentPage
{
    public _FundamentalsMenuPage()
    {
        InitializeComponent();
    }
    private async void BehaviorDemoPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new Fundamentals.BehaviorDemoPage());
	}
}