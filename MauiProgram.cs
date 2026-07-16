using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Platform;

namespace MyMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
                .ConfigureLifecycleEvents(events =>
                {
#if WINDOWS
                    events.AddWindows(windows => windows
                        .OnActivated((window, args) => 
                        {
                            LogEvent(nameof(WindowsLifecycle.OnActivated));
                            var appWindow = window.GetWindow();
                            System.Diagnostics.Debug.WriteLine(
                                $"MAUI Window Title: {appWindow?.Title}");
                            System.Diagnostics.Debug.WriteLine(
                                $"MAUI Window Size: {appWindow?.Width}x{appWindow?.Height}");
                        })
                        .OnClosed((window, args) => LogEvent(nameof(WindowsLifecycle.OnClosed)))
                        .OnLaunched((window, args) => LogEvent(nameof(WindowsLifecycle.OnLaunched)))
                        .OnLaunching((window, args) => LogEvent(nameof(WindowsLifecycle.OnLaunching)))
                        .OnVisibilityChanged((window, args) => LogEvent(nameof(WindowsLifecycle.OnVisibilityChanged), args.Visible ? "Visible" : "Hidden"))
                        .OnPlatformMessage((window, args) =>
                        {//system theme has changed
                            if (args.MessageId == Convert.ToUInt32("031A", 16))
                            {
                                LogEvent(nameof(WindowsLifecycle.OnPlatformMessage), "System theme changed");
                            }
                        })
                        .OnWindowCreated(window =>
                            {
                                window.SizeChanged += OnSizeChanged;
                            })
                    );
                static void OnSizeChanged(object sender, Microsoft.UI.Xaml.WindowSizeChangedEventArgs e)
                    {
                        System.Diagnostics.Debug.WriteLine($"Window size changed: {e.Size.Width}x{e.Size.Height}");
                        ILifecycleEventService service = MauiWinUIApplication.Current.Services.GetRequiredService<ILifecycleEventService>();
                        service.InvokeEvents(nameof(Microsoft.UI.Xaml.Window.SizeChanged));
                    }
                    
#endif
                    static bool LogEvent(string eventName, string type = null)
                    {
                        System.Diagnostics.Debug.WriteLine($"Lifecycle event: {eventName}{(type == null ? string.Empty : $" ({type})")}");
                        return true;
                    }
                });

            return builder.Build();
    
    }
}