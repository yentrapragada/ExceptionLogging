using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;

namespace LoggingExceptions
{
    public class Logger
    {
        //EventLogSource : LoggingError
        //EventLogName : SampleErrorLog

        //Log method which takes only exception as parameters
        public static void Log(Exception exception)
        {
            Log(exception, EventLogEntryType.Error);
        }
        //Log method which takes two parameters one is exception object and other is event log entry type
        public static void Log(Exception exception, EventLogEntryType eventLogEntryType)
        {
            StringBuilder sbExceptionMessage = new StringBuilder();
            do
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(exception.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);
                exception = exception.InnerException;
            } while (exception !=null);          

            if(EventLog.SourceExists("SampleErrorLog"))
            {
                //Creating object for the EventLog 
                EventLog log = new EventLog("LoggingError");
                log.Source = "SampleErrorLog";
                log.WriteEntry(sbExceptionMessage.ToString(), eventLogEntryType);
            }

        }
       

    }
}