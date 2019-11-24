using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary;
using System.Threading;
using System.Windows;

namespace OurDevices.ViewModels
{
    //TODO Load multiple Windows in to ShellView Model using Conductor<object>.Collection.OneActive
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            // Intitialize Database Connections
            GlobalConfig.InitializeConnections(DatabaseType.Sql);


            try
            {
              
                _existingDevices = new BindableCollection<DeviceModel>(GlobalConfig.Connection.GetDevice_All());
              
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Looks like the Database is not available error: {ex.Message}");
            }




        }
        public void ListRooms()
        {
            ActivateItemAsync(new ListRoomViewModel(), new CancellationToken());
        }

        public void LaunchCreateRoom()
        {
            ActivateItemAsync(new CreateRoomViewModel(), new CancellationToken());

        }

        public void LaunchCreateDevice()
        {
            ActivateItemAsync(new CreateDeviceViewModel(), new CancellationToken());

        }

        public void LaunchCreatePerson()
        {
            ActivateItemAsync(new CreatePersonViewModel(), new CancellationToken());
        }
        public void LaunchCreateDeviceAddress()
        {
            ActivateItemAsync(new CreateDeviceAddressViewModel(), new CancellationToken());
        }

        public void DevicesDataGrid()
        {
            ActivateItemAsync(new DevicesDataGridViewModel(), new CancellationToken());
        }

        public void PeopleDataGrid()
        {
            ActivateItemAsync(new PersonDataGridViewModel(), new CancellationToken());
        }


        
        private BindableCollection<DeviceModel> _existingDevices;

        public BindableCollection<DeviceModel> ExistingDevices
        {
            get { return _existingDevices; }
            set { _existingDevices = value; }
        }

        private DeviceModel _selectedDevice;

        public DeviceModel SelectedDevice
        {
            get { return _selectedDevice; }
            set 
            {
                _selectedDevice = value;
            NotifyOfPropertyChange(() => SelectedDevice); 
            }
        }

        private Screen _activeOurDeviceView;

        public Screen ActiveOurDeviceView
        {
            get { return _activeOurDeviceView; }
            set 
            { 
                _activeOurDeviceView = value;
                NotifyOfPropertyChange(() => ActiveOurDeviceView);
            }
        }


    }
}
