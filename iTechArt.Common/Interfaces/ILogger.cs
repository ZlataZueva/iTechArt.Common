using System;

namespace iTechArt.Common.Interfaces
{
    public interface ILogger
    {
        void Debug(string message);

        void Info(string message);

        void Warn(string message);

        void Warn(string message, Exception e);

        void Error(string message);

        void Error(string message, Exception e);

        void Fatal(string message);

        void Fatal(string message, Exception e);
    }
}