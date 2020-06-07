using CarteiraAcoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarteiraAcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        public Detalhes(CarteiraDeAcao carteira)
        {
            InitializeComponent();
            Title = carteira.Nome;
            Data.Text = carteira.Data.ToString();        
            Quantidade.Text = carteira.Quantidade;
            Preco.Text = carteira.Preco;
        }
        private async void btnPrevious_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}