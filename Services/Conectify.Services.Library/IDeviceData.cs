﻿using Conectify.Shared.Library.Models;

namespace Conectify.Services.Library
{
    public interface IDeviceData
    {
        ApiDevice Device { get; }

        IEnumerable<ApiSensor> Sensors { get; }

        IEnumerable<ApiActuator> Actuators { get; }

        IEnumerable<ApiPreference> Preferences { get;}
    }
}
