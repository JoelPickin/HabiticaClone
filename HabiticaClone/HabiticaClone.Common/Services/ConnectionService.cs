using HabiticaClone.Common.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace HabiticaClone.Common.Services
{
    public class ConnectionService : IConnectionService
    {
        public bool IsOnline()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsWifiConnection()
        {
            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
