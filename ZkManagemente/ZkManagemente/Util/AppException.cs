﻿using System;

namespace ZkManagement.Util
{
    class AppException:Exception
    {
        public AppException (string message): base(message)
        {

        }

        public AppException()
        {

        }

        public AppException(string message, string level, Exception ex) : base(message, ex)
        {
            ExType type = (ExType)Enum.Parse(typeof(ExType), level);
            switch (type)
            {
                case ExType.Error:
                    Logger.GetLogger("MESSAGE: " + ex.Message).Error("\n STACK TRACE: " + ex.StackTrace);
                    break;
                case ExType.Fatal:
                    Logger.GetLogger(ex.Message).Fatal("\n STACK TRACE: " + ex.StackTrace);
                    break;
            }
        }

        public enum ExType
        {
            Error,
            Fatal
        }
    }
}
