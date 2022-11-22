using Severino.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Severino.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}