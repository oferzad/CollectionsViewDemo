using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CollectionsViewDemo.Models
{
    class Student:INotifyPropertyChanged
    {
        public Student()
        {

        }

        private string firstName;
        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int AverageScore { get; set; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
