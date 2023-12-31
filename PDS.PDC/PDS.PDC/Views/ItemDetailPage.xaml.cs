using PDS.PDC.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PDS.PDC.Views
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