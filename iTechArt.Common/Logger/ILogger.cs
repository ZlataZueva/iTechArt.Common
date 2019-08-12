using System;

namespace iTechArt.Common.Logger
{
    public interface ILogger
    {
        void Debug(string message);

        void Info(string message);

        void Warn(string message, Exception e = null);

        void Error(string message, Exception e);

        void Fatal(string message, Exception e);
    }
}