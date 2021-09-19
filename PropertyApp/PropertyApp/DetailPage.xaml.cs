using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropertyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Property property)
        {
            InitializeComponent();
            this.Property = property;
            this.BindingContext = this;
        }
        public Property Property { get; private set; }
        public void GoBack(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DetailView.TranslationY = 600;
            DetailView.TranslateTo(0, 0, 500, Easing.SinInOut);
        }
    }
}