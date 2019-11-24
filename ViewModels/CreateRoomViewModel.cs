using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MyDotNetCoreLibrary;
using MyDotNetCoreLibrary.Models;

namespace OurDevices.ViewModels
{
    public class CreateRoomViewModel : Screen
    {
        private string _roomName;

        private string _roomLocation;

        public string RoomName
        {
            get { return _roomName; }
            set
            {
                _roomName = value;
                NotifyOfPropertyChange(() => RoomName);
            }
        }

        public string RoomLocation
        {
            get { return _roomLocation; }
            set
            {
                _roomLocation = value;
                NotifyOfPropertyChange(() => RoomLocation);
            }
        }


        private int _footage;

        public int Footage
        {
            get { return _footage; }
            set
            {
                _footage = value;
                NotifyOfPropertyChange(() => Footage);
            }
        }


        public bool CanCreateRoom(string roomName, string roomLocation)
        {
            return ValidateForm(roomName, roomLocation);
        }

        public void CreateRoom(string roomName, string roomLocation)
        {
            RoomModel p = new RoomModel();

            p.RoomName = roomName;
            p.RoomLocation = roomLocation;


            GlobalConfig.Connection.CreateRoom(p);

            //TODO Close form return to caller etc.

           // await EventAggregationProvider.MyDevicesEventAggregor.PublishOnUIThreadAsync(p);


           // await this.TryCloseAsync();

        }
        public void UpdateRoom(string roomName, string roomLocation)
        {
            RoomModel p = new RoomModel();

            p.RoomName = roomName;
            p.RoomLocation = roomLocation;

            GlobalConfig.Connection.UpdateRoom(p);
        }
        public void GotoRoom(string roomName, string roomLocation)
        {
            RoomModel p = new RoomModel();

            p.RoomName = roomName;

            //var model = 
            //var model = GlobalConfig.Connection.Goto(p);
            GlobalConfig.Connection.Goto(p);

            //foreach (var item in model)
            //{
            //    RoomLocation = item.RoomLocation;
            //}





        }
        private bool ValidateForm(string roomName, string roomLocation)
        {
            bool output = true;

            if (roomName.Length == 0)
            {
                output = false;
            }
            if (roomLocation.Length == 0)
            {
                output = false;
            }

            return output;
        }

    }
}
