using _2BAMaster.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace _2BAMaster.Views
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