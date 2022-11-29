using Severino.ContentViews;
using Severino.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Severino.Views
{
    public partial class IndexPage : ContentPage
    {
        ItemsViewModel _viewModel;
        public IndexPage()
        {

            InitializeComponent();


            ListServices.ItemsSource = new Models.Servicos[]
            {
                new Models.Servicos(){ Name = "Hidraulica" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Eletrica" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Climatizacao"  , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Jardinagem", ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))  },
                new Models.Servicos(){  Name = "Limpeza" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png")) },
            };

            ListLiked.ItemsSource = new Models.Servicos[]
            {
                new Models.Servicos(){ Name = "Hidraulica" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Eletrica" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Climatizacao"  , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))},
                new Models.Servicos(){  Name = "Jardinagem", ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"))  },
                new Models.Servicos(){  Name = "Limpeza" , ImageSource =  ImageSource.FromUri(new Uri("https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/512/external-plumber-labour-day-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png")) },
            };

            BindingContext = _viewModel = new ItemsViewModel();

        }
    }
}