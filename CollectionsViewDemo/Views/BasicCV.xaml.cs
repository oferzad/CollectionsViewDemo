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
    public partial class BasicCV : ContentPage
    {
        public BasicCV()
        {
            InitializeComponent();
            this.BindingContext = new StudentsViewModel();
            
        }
    }
}