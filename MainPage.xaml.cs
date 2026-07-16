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
	private async void HelloXaml(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.HelloXamlPage());
	}
	private async void XamlPlusCodePage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.XamlPlusCodePage());
	}
	private async void GridDemoPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.GridDemoPage());
	}
	private async void SharedResourcesPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.SharedResourcesPage());
	}
	private async void StaticConstantsPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.StaticConstantsPage());
	}

	private async void SliderBindingsPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.SliderBindingsPage());
	}
	private async void SliderTransformsPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.SliderTransformsPage());
	}
	private async void ListViewDemoPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.ListViewDemoPage());
	}
	private async void ClockPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.ClockPage());
	}
	private async void HslColorScrollPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.HslColorScrollPage());
	}
	private async void KeypadPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new XAML.KeypadPage());
	}
	private async void BehaviorDemoPage(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new Fundamentals.BehaviorDemoPage());
	}
}