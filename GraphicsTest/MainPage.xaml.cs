

using Microsoft.Maui.Controls;
using Timer = System.Timers.Timer;

namespace GraphicsTest;


public partial class MainPage : ContentPage
{
	
	private Timer _timer;
	private GraphicsView _clockGV;
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = this;
        _timer = new Timer(1000);
        _timer.AutoReset = true;
		_clockGV = this.clockGraphicsView;
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();      
        _timer.Elapsed += OnClockTimer;      
        _timer.Start();
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
        _timer.Elapsed -= OnClockTimer;
		_timer.Stop();	
    }

	private void OnClockTimer(object sender, System.Timers.ElapsedEventArgs e) =>
        _clockGV.Invalidate();	
}

