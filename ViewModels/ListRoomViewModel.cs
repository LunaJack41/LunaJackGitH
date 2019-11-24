using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary.Models;
using MyDotNetCoreLibrary;


namespace OurDevices.ViewModels
{
    public class ListRoomViewModel : Screen
    {
        public ListRoomViewModel()
        {
            ExistingRooms = new BindableCollection<RoomModel>(GlobalConfig.Connection.GetRoom_All());
        }
        private string _roomName;

        public string RoomName
        {
            get { return _roomName; }
            set 
            { 
                _roomName = value;
                NotifyOfPropertyChange(() => RoomName);
            }
        }

        private string _roomLocation;

        public string RoomLocation
        {
            get { return _roomLocation; }
            set 
            { 
                _roomLocation = value;
                NotifyOfPropertyChange(() => RoomLocation);
            }
        }

        private BindableCollection<RoomModel> _existingRooms;

        public BindableCollection<RoomModel> ExistingRooms
        {
            get { return _existingRooms; }
            set { _existingRooms = value; }
        }

        private RoomModel _selectedRoom;

        public RoomModel SelectedRoom
        {
            get { return _selectedRoom; }
            set
            {
                _selectedRoom = value;
                NotifyOfPropertyChange(() => SelectedRoom);
            }
        }

    }
}
