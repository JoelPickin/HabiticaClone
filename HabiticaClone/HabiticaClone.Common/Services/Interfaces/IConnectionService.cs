using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Common.Services.Interfaces
{
    public interface IConnectionService
    {
        bool IsOnline();
        bool IsWifiConnection();
    }
}
