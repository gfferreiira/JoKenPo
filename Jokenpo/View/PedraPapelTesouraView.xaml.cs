using Jokenpo.ViewModel;
namespace Jokenpo.View;

public partial class PedraPapelTesouraView : ContentPage
{
	public PedraPapelTesouraView()
	{

		BindingContext = new JogadorViewModel();
		InitializeComponent();
	}
}