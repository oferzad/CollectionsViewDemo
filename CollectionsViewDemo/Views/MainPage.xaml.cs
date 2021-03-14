using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionsViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {

        }

        private async void vcDataBinding_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataBindingDemo());
        }

        private async void vcRefresh_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefreshCV());
        }

        private async void vcContext_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContextMenuCV());
        }

        private async void vcSelection_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectionCV());
        }

        private async void vcItemLayout_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemLayoutCV());
        }

        private async void vcBasic_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasicCV());
        }
    }
}
