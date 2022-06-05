using System;
using System.Collections.Generic;
using System.Text;

namespace Stepper
{
    public interface IStepCounter
    {
        int Steps { get; set; }

        bool IsAvailable();

        void InitSensorService();

        void StopSensorService();
    }

}
