using CollectionsViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionsViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemLayoutCV : ContentPage
    {
        public ItemLayoutCV()
        {
            InitializeComponent();
            this.BindingContext = new StudentsViewModel();
        }
    }
}