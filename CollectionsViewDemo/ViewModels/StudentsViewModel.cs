using CollectionsViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionsViewDemo.ViewModels
{
    class StudentsViewModel
    {
        private ObservableCollection<Student> students;

        public ObservableCollection<Student> StudentsList
        {
            get
            {
                return students;
            }
        }

        public StudentsViewModel()
        {
            this.students = new ObservableCollection<Student>();
            CreateCollection();
        }
        private void CreateCollection()
        {
            this.students.Add(new Student
            {
                FirstName = "Ofer",
                LastName = "Zadikario",
                BirthDate = new DateTime(1972, 11, 15),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Tal",
                LastName = "Simon",
                BirthDate = new DateTime(1975, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Racheli",
                LastName = "Zosiman",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Smadar",
                LastName = "Vechter",
                BirthDate = new DateTime(1965, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Adi",
                LastName = "Menahem",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });


        }

        public ICommand DeleteCommand => new Command<Student>(RemoveStudent);
        public ICommand FavoriteCommand => new Command<Student>(FavoriteStudent);

        void RemoveStudent(Student st)
        {
            if (StudentsList.Contains(st))
            {
                StudentsList.Remove(st);
            }
        }

        void FavoriteStudent(Student st)
        {
            //Do something
        }

    }
}
