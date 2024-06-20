using JokenPo.ViewModels;

namespace JokenPo.Views;

public partial class JokenViewxaml : ContentPage
{
	public JokenViewxaml()
	{
		InitializeComponent();
		BindingContext = new JokenViewModel();
	}
}