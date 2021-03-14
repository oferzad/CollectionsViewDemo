using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsViewDemo.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionsViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingDemo : ContentPage
    {
        Student uri;
        public DataBindingDemo()
        {
            InitializeComponent();
            uri = new Student
            {
                FirstName = "Uri",
                LastName = "Zadikario",
                BirthDate = new DateTime(2006, 2, 21),
                AverageScore = 85

            };
            BindingContext = uri;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            uri.FirstName = "Ofer";
            //To show two way binding mode
            //lbl.Text = "Ofer";
        }
    }
}