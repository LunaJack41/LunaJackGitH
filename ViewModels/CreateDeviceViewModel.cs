using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;

namespace OurDevices.ViewModels
{
    public class CreateDeviceViewModel : Screen, IHandle<PersonModel>
    {
        //  private int _id;
        private string _deviceName = " ";
        private string _deviceType = " ";
        private string _ipAddress = " ";
        private string _macAddress = " ";
        private char _mobile = ' ';

        public CreateDeviceViewModel()
        {
            string searchString = "Y";

            AvailableIPAddress = new BindableCollection<DeviceAddressModel>(GlobalConfig.Connection.GetDeviceAddress_Available(searchString));
            AvailableDevices = new BindableCollection<DeviceModel>(GlobalConfig.Connection.GetDevice_All());
            EventAggregationProvider.OurDevicesEventAggregor.SubscribeOnPublishedThread(subscriber:this);

            

        }

        //public int id
        //{
        //    get { return _id; }

        //}


        public string DeviceName
        {
            get { return _deviceName; }
            set
            {
                _deviceName = value;

                NotifyOfPropertyChange(() => DeviceName);
               // NotifyOfPropertyChange(() => CanAddDevice);
            }
        }


        public string DeviceType
        {
            get { return _deviceType; }
            set
            {
                _deviceType = value;

                NotifyOfPropertyChange(() => DeviceType);
            }
        }


        public string IPAddress
        {
            get { return _ipAddress; }
            set
            {
                _ipAddress = value;
                NotifyOfPropertyChange(() => IPAddress);
            }
        }



        public string MACAddress
        {
            get { return _macAddress; }
            set
            {
                _macAddress = value;
                NotifyOfPropertyChange(() => MACAddress);
            }
        }


        public char Mobile
        {
            get { return _mobile; }
            set
            {
                _mobile = value;
                NotifyOfPropertyChange(() => Mobile);
            }
        }

        private BindableCollection<DeviceAddressModel> _availableIPAddress;

        public BindableCollection<DeviceAddressModel> AvailableIPAddress
        {
            get { return _availableIPAddress; }
            set { _availableIPAddress = value; }
        }

        private DeviceAddressModel _selectedIPAddressToAdd;

        public DeviceAddressModel SelectedIPAdressToAdd
        {
            get { return _selectedIPAddressToAdd; }
            set 
            {
                _selectedIPAddressToAdd = value;
                NotifyOfPropertyChange(() => SelectedIPAdressToAdd);
                
            }
        }
        private BindableCollection<DeviceModel>  _availableDevices;

        public BindableCollection<DeviceModel>  AvailableDevices
        {
            get { return _availableDevices; }
            set { _availableDevices = value; }
        }
        private DeviceModel _selectedDeviceToEdit;

        public DeviceModel SelectedDeviceToEdit
        {
            get { return _selectedDeviceToEdit; }
            set { 
                _selectedDeviceToEdit = value;
                NotifyOfPropertyChange(() => SelectedDeviceToEdit);
                }
        }

        

        //TODO not sure if I need this line or not?
        //public bool CanAddDevice
        //{-
        //    get
        //    {
        //        return DeviceName != null;
        //    }
        //}



        

        public void CancelCreation()
        {
            EventAggregationProvider.OurDevicesEventAggregor.PublishOnUIThreadAsync(new DeviceModel());
            this.TryCloseAsync();
        }

        public bool CanCreateDevice(string deviceName, string deviceType, string ipAddress, string macAddress, char mobile)
        {
            if (string.IsNullOrWhiteSpace(deviceName) || string.IsNullOrWhiteSpace(deviceType))
            {
                return false;
            }
            else
            {
               
                return true;
            }
        }
        
        public void CreateDevice(string deviceName, string deviceType, string ipAddress, string macAddress, bool mobile)
        {
            DeviceModel model = new DeviceModel()
            {
                DeviceName = deviceName,
                DeviceType = deviceType,
                IpAddress = SelectedIPAdressToAdd.IPAddress,
                MACAddress = macAddress,
                Mobile = mobile
            };

                try
                {
                    GlobalConfig.Connection.CreateDevice(model);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"The Database is not available error: {ex.Message}");
                    return;
                }

                DeviceName = "";
                DeviceType = "";
                IPAddress = "";
                MACAddress = "";
                Mobile = 'N';
            }

        public void Retrieve()
        {

        }
        //TODO Finish Update
        public void Update(string deviceName, string deviceType, string ipAddress, string macAddress, bool mobile)
        {
            DeviceModel model = new DeviceModel()
            {
                DeviceName = deviceName,
                DeviceType = deviceType,
                IpAddress = SelectedIPAdressToAdd.IPAddress,
                MACAddress = macAddress,
                Mobile = mobile
            };
            GlobalConfig.Connection.Update<DeviceModel>(model);


        }


        public void DeleteDevice()
        {
            GlobalConfig.Connection.DeleteDevice("Netgear");
        }


        private bool ValidateForm(string deviceName, string deviceType, string ipAddress, string macAddress, char mobile)
        {
            bool output = true;

            if (deviceName.Length > 0 && deviceType.Length > 0) 
            {
                output = true;
            }
            else
            {
                MessageBox.Show("We cannot accept blank entries in the Device Name field");
                output = false;
            }


            return output;
        }

        //TODO Make HandleAsync work  WPF Addon Connect forms may be starting point then on to .NET CORE upgrade
        //Task can return VOID like below or return Task<T> ie. Task<string> 
        public Task HandleAsync(PersonModel message, CancellationToken cancellationToken)
        {
            Task.Run(() => MessageBox.Show($"Running Asynch Task Person Model First Name is { message.FirstName } "));
            return Task.CompletedTask;

            // Add async keyword in Method definition and remove return to change from Task type to asynch Task type
            // await Task.Run(() => MessageBox.Show($"Running Asynch Task Person Model First Name is { message.FirstName } "));
            //

        }
    }
}
