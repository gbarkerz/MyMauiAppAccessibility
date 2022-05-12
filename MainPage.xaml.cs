using System.Collections.ObjectModel;

namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Monkey> Monkeys { get; }

	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Monkeys = new ObservableCollection<Monkey>();
		Monkeys.Add(new Monkey { Name = "Blue monkey", Location = "Central and East Africa",
			Picture = ImageSource.FromFile("TestPicture.jpg")
		});
		Monkeys.Add(new Monkey { Name = "Pied tamarin", Location = "Brazilian Amazon Rainforest",
			Picture = ImageSource.FromFile("TestPicture.jpg")
		});

		CollectionViewTest.ItemsSource = Monkeys;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

public class Monkey
{
	public string Name { get; set; }
	public string Location { get; set; }
	public ImageSource Picture { get; set; }
}