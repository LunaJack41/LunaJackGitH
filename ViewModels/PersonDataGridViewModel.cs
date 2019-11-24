using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary.DataAccess;
using MyDotNetCoreLibrary;

namespace OurDevices.ViewModels
{
    public class PersonDataGridViewModel
    {
        public PersonDataGridViewModel()
        {
            People = new BindableCollection<PersonModel>(GlobalConfig.Connection.GetPerson_All());
        }


        private BindableCollection<PersonModel> _people;

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }


    }
}
