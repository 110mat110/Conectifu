﻿using Conectify.Services.Library;
using Conectify.Shared.Library.Models;

namespace Conectify.Services.Automatization;

public class DeviceData : IDeviceData
{
    private readonly AutomatizationConfiguration configuration;

    public DeviceData(AutomatizationConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public ApiDevice Device => new ApiDevice()
    {
        Id = configuration.DeviceId,
        IPAdress = "192.168.1.1",
        MacAdress = "xx.xx.xx",
        Name = "Shelly server"
    };

    public IEnumerable<ApiSensor> Sensors => new List<ApiSensor>()
        {
            new ApiSensor()
            {
                Id = configuration.SensorId,
                Name = "TestSensor",
                SourceDeviceId = configuration.DeviceId,
            }
        };

    public IEnumerable<ApiActuator> Actuators => new List<ApiActuator>()
        {
            new ApiActuator()
            {
                Id = configuration.ActuatorId,
                Name = "TestActuator",
                SourceDeviceId = configuration.DeviceId,
                SensorId = configuration.SensorId
            }
        };

    public IEnumerable<ApiPreference> Preferences => new List<ApiPreference>();
}
