using Android.App;
using CarteiraAcoes.Data;
using CarteiraAcoes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarteiraAcoes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listaDeAcoes.ItemsSource = Database.carteiras;
            Title = "Carteira de Ações";

        }

        private void Cadastrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nome.Text) || string.IsNullOrEmpty(qtd.Text) || string.IsNullOrEmpty(preco.Text))
            {
                DisplayAlert("Aviso!", "Preencha todos os campos.", "Ok");
            }                    
            else
            {
                CarteiraDeAcao carteira = new CarteiraDeAcao(nome.Text, qtd.Text, preco.Text);
                carteira.Data = DateTime.Now;
                Database.carteiras.Add(carteira);                
                DisplayAlert("Cadastro Realizado", "Fundo cadastrado com sucesso!", "Ok");
                nome.Text = "";
                qtd.Text = "";
                preco.Text = "";                
            }                
        }

        private async void listaDeAcoes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CarteiraDeAcao fundoSelected = (CarteiraDeAcao)e.SelectedItem;
            Detalhes detalhesPage = new Detalhes(fundoSelected);
            await Navigation.PushAsync(detalhesPage);
        }
    }
}
