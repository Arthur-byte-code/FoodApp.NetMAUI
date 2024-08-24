using LanchesApp.Model;
namespace LanchesApp.Telas;

public partial class LancheDetailsPage : ContentPage
{ 
	Lanches _lanche;


	public LancheDetailsPage(Lanches lanche)
	{
		InitializeComponent();
	_lanche = lanche;
	this.BindingContext =_lanche;
	}

    private void btnProximo_Clicked(object sender, EventArgs e)
    {
	if (_lanche == null)
		return;
	//awai this.Navigation.PushAsync(new LanchePedidoPage(_lanche));
		
    }
}