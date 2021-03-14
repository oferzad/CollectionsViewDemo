using CollectionsViewDemo.Models;
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
    public partial class SelectionCV : ContentPage
    {
        public SelectionCV()
        {
            InitializeComponent();
            this.BindingContext = new StudentsViewModel();
            previousSelectedItemLabel.Text = "none";
            currentSelectedItemLabel.Text = "none";
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            previousSelectedItemLabel.Text = "none";
            currentSelectedItemLabel.Text = "none";

            if (e.PreviousSelection.Count > 0)
            {
                foreach (Student st in e.PreviousSelection)
                    if (previousSelectedItemLabel.Text == "none")
                        previousSelectedItemLabel.Text = st.FirstName;
                    else
                        previousSelectedItemLabel.Text += $",{st.FirstName}";
            }

            if (e.CurrentSelection.Count > 0)
            {
                foreach (Student st in e.CurrentSelection)
                    if (currentSelectedItemLabel.Text == "none")
                        currentSelectedItemLabel.Text = st.FirstName;
                    else
                        currentSelectedItemLabel.Text += $",{st.FirstName}";
            }

        }
    }
}