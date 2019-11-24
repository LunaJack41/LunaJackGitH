using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace OurDevices
{
        public static class EventAggregationProvider
        {
            public static EventAggregator OurDevicesEventAggregor { get; set; } = new EventAggregator();
        }
    
}
