using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary;
using System.Windows;


namespace OurDevices.ViewModels
{
    public class CreateDeviceAddressViewModel : Screen
    {       
                
        private string _iPAddress;
        private string _available; 
        private string _mACAddress;


        public CreateDeviceAddressViewModel()
        {
            EventAggregationProvider.OurDevicesEventAggregor.SubscribeOnPublishedThread(subscriber: this);
        }


        public string IPAddress
        {
            get { return _iPAddress; }
            set 
            { 
                _iPAddress = value;
                NotifyOfPropertyChange(() => IPAddress);
            
            }
        }

        public string MACAddress
        {
            get { return _mACAddress; }
            set 
            { 
                _mACAddress = value;
                NotifyOfPropertyChange(() => MACAddress);
            }
        }

                        
        public string Available
        {
            get { return _available; }
            set 
            { 
                _available = value;
                NotifyOfPropertyChange(() => Available);
            }
        }


        





        //TODO Create Validation
        public bool CanSave(string ipAddress, string mACAddress, string available)
        {
            if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(available))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Save(string ipAddress, string mACAddress, string available)
        {
            DeviceAddressModel model = new DeviceAddressModel()
            {
                IPAddress = ipAddress,
                MACAddress = mACAddress,
                Available = available,    
            };

            try
            {
                GlobalConfig.Connection.Save(model);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"The Database is not available error: { ex.Message }");
            }

            IPAddress = "";
            MACAddress = "";
            Available = "";




        }
        public void Cancel()
        {
            this.TryCloseAsync();
        }

        //TODO Create Delete method and add it to all screens
        public void Delete()
        {

        }
    }
}
