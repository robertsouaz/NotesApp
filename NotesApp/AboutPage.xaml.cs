

namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

		private void PerfilBotao_Clicked(object sender, EventArgs e)
		{
		Uri link = new Uri("https://www.nasa.gov/");
		Launcher.OpenAsync(link);
		}
			
	}
}