using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CollectionsViewDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionsViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefreshCV : ContentPage
    {
        public RefreshCV()
        {
            InitializeComponent();
            this.BindingContext = new StudentsViewModel();
        }

        public ICommand refreshCommand => new Command(Refresh);

        private void Refresh()
        {
            StudentsViewModel stVM = (StudentsViewModel)BindingContext;
            stVM.StudentsList.Add(new Models.Student
            {
                FirstName = "Just",
                LastName = "Added!",
                BirthDate = DateTime.Now,
                AverageScore = 100
            });
            refreshView.IsRefreshing = false;
        }
    }
}