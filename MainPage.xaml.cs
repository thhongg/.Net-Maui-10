namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OpenXamlMenu(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML._XamlMenuPage());
	}

	private async void OpenFundamentalsMenu(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Fundamentals._FundamentalsMenuPage());
	}
	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

}