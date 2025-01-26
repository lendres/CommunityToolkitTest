using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuTest;

public partial class MainViewModel : ObservableObject
{
	public Page? MenuHostingPage { get;  set; }

	[ObservableProperty]
	public partial int Count { get; set; } = 0;

	[ObservableProperty]
	public partial string CountMessage { get; set; } = "Click Count";

	public MainViewModel()
    {
	}

	partial void OnCountChanged(int value)
	{
	}

	[RelayCommand]
	void Increment()
	{
		Count++;
		CountMessage = $"Click count: {Count}";
	}
}