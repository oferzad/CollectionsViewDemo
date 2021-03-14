using CollectionsViewDemo.Models;
using CollectionsViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionsViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextMenuCV : ContentPage
    {
        public ContextMenuCV()
        {
            InitializeComponent();
            this.BindingContext = new StudentsViewModel();
            

        }


        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            
        }
    }
}