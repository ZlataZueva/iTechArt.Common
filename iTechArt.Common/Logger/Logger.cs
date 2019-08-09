using System;
using log4net;
using log4net.Config;

namespace iTechArt.Common.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog _log;


        public Logger(Type type)
        {
            _log = LogManager.GetLogger(type);
            XmlConfigurator.Configure();
        }


        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Warn(string message, Exception e = null)
        {
            _log.Warn(message, e);
        }

        public void Error(string message, Exception e = null)
        {
            _log.Error(message, e);
        }

        public void Fatal(string message, Exception e = null)
        {
            _log.Fatal(message, e);
        }
    }
}