using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary.DataAccess;
using MyDotNetCoreLibrary;
using System.Threading;
using System.Threading.Tasks;

namespace OurDevices.ViewModels
{
    public class DevicesDataGridViewModel : Screen
    {
        public DevicesDataGridViewModel()
        {
            Devices = new BindableCollection<DeviceModel>(GlobalConfig.Connection.GetDevice_All());
        }


        private BindableCollection<DeviceModel> _devices;

        public BindableCollection<DeviceModel> Devices
        {
            get { return _devices; }
            set { _devices = value; }
        }
        private DeviceModel _selectedDeviceToAdd;

        public DeviceModel SelectedDeviceToAdd
        {
            get { return _selectedDeviceToAdd; }
            set
            {
                _selectedDeviceToAdd = value;
                NotifyOfPropertyChange(() => SelectedDeviceToAdd);
            }
        }

        
    }
}
