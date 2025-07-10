namespace Htg.Hic.EE4Show.ViewModels;

public class MainWindowViewModel : BindableBase
{
	private string _title = "IShip System";

	public string Title
	{
		get { return _title; }
		set { SetProperty(ref _title, value); }
	}

	private string _bgPath;

	public string BgPath
	{
		get { return _bgPath; }
		set { SetProperty(ref _bgPath, value); }
	}

	public List<string> Backgrounds { get; set; } = [
			"/Resources/Images/2025-06-20_163119.png",
			"/Resources/Images/2025-06-20_162947.png",
			"/Resources/Images/2025-06-20_163226.png",
			"/Resources/Images/2025-06-20_163320.png",
			"/Resources/Images/2025-06-25_114847.png",
			"/Resources/Images/2025-06-25_115034.png",
			"/Resources/Images/2025-06-25_115046.png",
			"/Resources/Images/2025-06-25_115059.png",
			"/Resources/Images/2025-06-25_115117.png"
		];

	public MainWindowViewModel()
	{
		Task.Run(async () =>
		{
			var i = 0;
			while (true)
			{
				BgPath = Backgrounds[i];
				await Task.Delay(5 * 1000);
				i++;
				if (i >= Backgrounds.Count)
					i = 0;
			}
		}, CancellationToken.None);
	}
}