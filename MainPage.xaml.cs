using LanchesApp.Model;
using LanchesApp.Telas;

namespace LanchesApp;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
        lvLanches.ItemsSource = new List<Lanches>
        {
            new Lanches { Nome = "Cheese Burguer", Descricao="", Status="Ativo", Preco=12.90M ,ImagemUrl= "https://www.bobs.com.br/media/filer_public_thumbnails/filer_public/a5/0a/a50ae724-57c9-4ed0-922e-c5434576689b/036_bobs_altualizacao_cardapio_site_610x400_cheeseburguer.png__1200x630_subsampling-2_upscale.png" },
            new Lanches { Nome = "Cheese Salada", Descricao = "", Status = "Ativo", Preco = 14.50M, ImagemUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEh9VAazmG6DDB9R86lleQcV0vPdMWxACBBvhLBHv05pBS83_k6YbX0LtFCSRC9LjwqTMlevaMhvwzWF0HSZVaM3Kvy6PxvUIdxi16IiYSyG2IEWQgnlsB5IzrE8Zu9Xd10wLVaa7Xg8WRMH/s640/dfhgad.png" },
            new Lanches { Nome = "Cheese Egg", Descricao = "", Status = "Ativo", Preco = 15.50M, ImagemUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kPXSRC5A/200/200/original?country=br" },
            new Lanches { Nome = "Cheese Tudo", Descricao = "", Status = "Ativo", Preco = 18.00M, ImagemUrl = "https://padariasantacruz.loji.com.br/storage/uploads/NeDNbSzo4Uk2iSlSqLH2mArQq3JzZfHd7KNLyBAP.png" },
            new Lanches { Nome = "Lanche de frango", Descricao = "", Status = "Ativo", Preco = 13.90M, ImagemUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kAXhlMlK/200/200/original?country=br" },
            new Lanches { Nome = "Misto Quente", Descricao = "", Status = "Ativo", Preco = 10.50M, ImagemUrl = "https://lh4.googleusercontent.com/proxy/6evH4T0kG1s-rdzP2D-zrK0HDfwjhLvlz3oSr-f_q5J0aa6_Qi4qokKBHhnXUtn0lN_9sQ4GACpNy4FNPhNqUPzARFuxhRzSnEwQ2kN0L8w" },
            };
    }

    

    public async void lvLanches_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var lanche = e.SelectedItem as Lanches;
        if (lanche == null) 
        
            return;
            await this.Navigation.PushAsync(new LancheDetailsPage(lanche));
        
    }
}
