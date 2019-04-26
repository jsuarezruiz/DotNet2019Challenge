using DotNet2019Challenge.ViewModels;
using Xamarin.Forms;

namespace DotNet2019Challenge.Views
{
    public partial class MoviesView : ContentPage
	{
        MoviesViewModel _vm;

        public MoviesView ()
		{
			InitializeComponent ();

            _vm = new MoviesViewModel();
            BindingContext = _vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
 
            await _vm.LoadDataAsync();
        }
    }
}