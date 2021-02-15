using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Weather.ViewModels;

namespace Xamarin_Weather.Views
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