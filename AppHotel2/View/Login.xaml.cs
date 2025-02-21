﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;

        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            string email = txt_email.Text;

            string email_correto = "bellaetec@gmail.com";
            string usuario_correto = "Bella";
            string senha_correta = "1234";

            if (usuario == usuario_correto && senha == senha_correta && email == email_correto) 
            {
                App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new NavigationPage (new ContratacaoHospedagem());

          
            }
            else
                DisplayAlert("Atenção", "Usuário ou senha incorretos.", "OK");
        }
    }
}