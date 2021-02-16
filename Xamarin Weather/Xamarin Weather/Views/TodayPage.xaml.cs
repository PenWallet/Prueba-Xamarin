using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Weather.ViewModels;

namespace Xamarin_Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodayPage : ContentPage
    {
        public TodayPage()
        {
            try
            {
                InitializeComponent();
            }catch(Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
        }
    }
}