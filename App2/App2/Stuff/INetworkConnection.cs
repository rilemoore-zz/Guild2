﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
       // void CheckNetworkConnection();
    }
}
