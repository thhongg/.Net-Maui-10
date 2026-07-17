namespace MyMauiApp.XAML;

public partial class _XamlMenuPage : ContentPage
{
    public _XamlMenuPage()
    {
        InitializeComponent();
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
}

