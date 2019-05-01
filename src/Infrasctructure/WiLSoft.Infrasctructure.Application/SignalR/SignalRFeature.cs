using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Infrasctructure.Application.SignalR
{
    public static class SignalRFeature
    {
        public static bool IsAvailable
        {
            get
            {
#if FEATURE_SIGNALR
                return true;
#else
                return false;
#endif
            }
        }
    }
}
