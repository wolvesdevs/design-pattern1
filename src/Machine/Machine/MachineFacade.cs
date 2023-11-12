using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public static class MachineFacade
    {
        private static int _fanStopValue;

        public static int BoxInternalTemperatureFunStop()
        {
            FanStop(0);

            try
            {
                System.Threading.Thread.Sleep(30000);
                var result = new Box().GetInternalTemperature();
                _fanStopValue = result;
                return result;
            }
            finally
            {
                FanStart(0);
            }
        }

        public static int BoxInternalTemperature()
        {
            return new Box().GetInternalTemperature();
        }
        
        public static int BoxInternalTemperatureFunStopInMemory()
        {
            return _fanStopValue;
        }

        public static int BoxExternalTemperature()
        {
            return new Box().GetExternalTemperature();
        }

        public static void CameraTake()
        {
            if (BoxInternalTemperature() > 70)
            {
                throw new Exception("内部温度が70度を超えています。");
            }

            new Camera().Take();
        }

        public static FanEntity FanSpin(int fanId)
        {
            return new Fan().GetSpin(fanId);
        }

        public static void FanStart(int fanId)
        {
            new Fan().Start(fanId);
        }

        public static void FanStop(int fanId)
        {
            new Fan().Stop(fanId);
        }

        public static void PowerOn()
        {
            new Power().On();
        }

        public static void PowerOff()
        {
            new Power().Off();
        }

        public static void BacklightOff()
        {
            new Power().BacklightOff();
        }
    }
}
