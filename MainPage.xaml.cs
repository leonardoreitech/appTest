using Library;

namespace jenkinsAndroid;

public partial class MainPage : ContentPage
{
	int count = 0;

	private Class1 Class;
	public Class1 classs
	{
		get => Class;
		set
		{
			Class = value;
			OnPropertyChanged();
		}
	}
	private string _testBinding;
	public string C_testBinding
	{
		get => _testBinding;
		set
		{
			_testBinding = value;
			OnPropertyChanged();
		}
	}

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;

		classs = new();
		classs.name = "Bem vindo";

		C_testBinding = classs.name;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

