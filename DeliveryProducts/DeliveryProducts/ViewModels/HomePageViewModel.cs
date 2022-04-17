using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DeliveryProducts.ViewModels
{
    public class HomePageViewModel : BindableObject
    {
        public HomePageViewModel()
        {
            BindingContext = this;

            ShowBussines = new Command(OnShowBussines);
        }

        void OnShowBussines()
        {
            Bussines = "Mostrando negocios......";
        }

        public ICommand ShowBussines { get; }

        private string bussines = "Todos los negocios";

        public string Bussines
        {
            get => bussines;

            set 
            {
                if (value == bussines)
                    return;

                bussines = value;
                OnPropertyChanged();
            }
        }
    }
}
