﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public static class MachineFacade
    {
        private static int _fanStopValue;

        /// <summary>
        /// ファン停止時の内部温度を取得する
        /// </summary>
        /// <returns>ファン停止時の内部温度</returns>
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

        /// <summary>
        /// 内部温度を取得する
        /// </summary>
        /// <returns>内部温度</returns>
        public static int BoxInternalTemperature()
        {
            return new Box().GetInternalTemperature();
        }

        /// <summary>
        /// ファンを停止した内部温度の前回値を取得
        /// </summary>
        /// <returns>ファンを停止した内部温度の前回値</returns>
        public static int BoxInternalTemperatureFunStopInMemory()
        {
            return _fanStopValue;
        }
        /// <summary>
        /// 外部温度の取得
        /// </summary>
        /// <returns>外部温度</returns>
        public static int BoxExternalTemperature()
        {
            return new Box().GetExternalTemperature();
        }

        /// <summary>
        /// 写真を撮る
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void CameraTake()
        {
            if (BoxInternalTemperature() > 70)
            {
                throw new Exception("内部温度が70度を超えています。");
            }

            new Camera().Take();
        }

        /// <summary>
        /// ファンの回転数を取得
        /// </summary>
        /// <param name="fanId">ファンID</param>
        /// <returns>ファンの回転数</returns>
        public static FanEntity FanSpin(int fanId)
        {
            return new Fan().GetSpin(fanId);
        }
        
        /// <summary>
        /// ファンを動かす
        /// </summary>
        /// <param name="fanId">ファンID</param>
        public static void FanStart(int fanId)
        {
            new Fan().Start(fanId);
        }

        /// <summary>
        /// ファンを止める
        /// </summary>
        /// <param name="fanId">ファンID</param>
        public static void FanStop(int fanId)
        {
            new Fan().Stop(fanId);
        }

        /// <summary>
        /// 電源ON
        /// </summary>
        public static void PowerOn()
        {
            new Power().On();
        }

        /// <summary>
        /// 電源OFF
        /// </summary>
        public static void PowerOff()
        {
            new Power().Off();
        }

        /// <summary>
        /// バックライトOFF
        /// </summary>
        public static void BacklightOff()
        {
            new Power().BacklightOff();
        }
    }
}
