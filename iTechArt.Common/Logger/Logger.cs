using System;
using iTechArt.Common.Interfaces;
using log4net;

namespace iTechArt.Common.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog _log;


        public Logger(Type type)
        {
            _log = LogManager.GetLogger(type);
        }


        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }

        public void Warn(string message, Exception e)
        {
            _log.Warn(message, e);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public void Error(string message, Exception e)
        {
            _log.Error(message, e);
        }

        public void Fatal(string message)
        {
            _log.Fatal(message);
        }

        public void Fatal(string message, Exception e)
        {
            _log.Fatal(message, e);
        }
    }
}