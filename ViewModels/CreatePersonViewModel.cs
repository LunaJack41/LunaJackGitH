using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary;
using MyDotNetCoreLibrary.Models;


namespace OurDevices.ViewModels
{
    public class CreatePersonViewModel : Screen
    {
        private string _firstName;
        private string _lastName;
        private string _age;
        private string _emailAddress;
        private string _cellphoneNumber;
       

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                _firstName = value;

                NotifyOfPropertyChange(() => FirstName); 
                NotifyOfPropertyChange(() => FullName);
            }
        }

        

        public string LastName
        {
            get { return _lastName; }
            set 
            {
                _lastName = value;

                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        

        public string Age
        {
            get { return _age; }
            set 
            {
                _age = value;

                NotifyOfPropertyChange(() => Age);
            }
        }

        

        public string EmailAddress
        {
            get { return _emailAddress; }
            set 
            {
                _emailAddress = value;

                NotifyOfPropertyChange(() => EmailAddress);
            }
        }

        

        public string CellphoneNumber
        {
            get { return _cellphoneNumber; }
            set 
            {
                _cellphoneNumber = value;   

                NotifyOfPropertyChange(() => CellphoneNumber);
            }
        }

        

        public string FullName
        {
            get { return $" {FirstName} { LastName }"; }
           
        }






        public bool CanCreatePerson(string firstName, string lastName, string emailAddress, string cellphoneNumber, string age)
        {
            return ValidateForm(FirstName, LastName, EmailAddress, CellphoneNumber, Age);
        }

        public void CreatePerson(string firstName, string lastName, string emailAddress, string cellphoneNumber, string age)
        {
            PersonModel model = new PersonModel { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, CellphoneNumber = cellphoneNumber, Age = age };

            GlobalConfig.Connection.CreatePerson(model);

            EventAggregationProvider.OurDevicesEventAggregor.PublishOnUIThreadAsync(model);
            
        }

        private bool ValidateForm(string firstName, string lastName, string emailAddress, string cellphoneNumber, string age)
        {
            return true;
        }



    }
}
