using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public int SerialNumber { get; }
        public int Output { get; protected set; }
        public string EngineType { get; protected set; }
        public bool HasFasterThanLightDrive { get; protected set; }

        public Engine(
            int serialNumber,
            int output,
            string engineType,
            bool hasFasterThanLightDrive)
        {
            SerialNumber = serialNumber;
            Output = output;
            EngineType = engineType;
            HasFasterThanLightDrive = hasFasterThanLightDrive;
        }

        public void IncreasePower()
        {
            if (HasFasterThanLightDrive)
                Output *= 10;
            else
                Output += 1;
        }

        public void DecreasePower()
        {
            if (HasFasterThanLightDrive)
                Output = Output / 10;
            else
                Output -= 1;
        }
    }
}
