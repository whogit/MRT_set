using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ToolLibrary
{
    public class LogTools
    {

        public static void ClearLog(string Log)
        {
            foreach (var eventLog in EventLog.GetEventLogs())
            {
                // Console.WriteLine(eventLog.LogDisplayName);
                if (eventLog.LogDisplayName == Log)
                {
                    Console.WriteLine("I found " + eventLog.LogDisplayName);
                    Console.WriteLine("Clearing Log...");
                    eventLog.Clear();
                }
            }
        }
        public static void MakeLogEntry()
        {
            // It is quite easy to write to the Application
            // log but much more involved to write to the
            // System log.  I prefer not to mess with the
            // System log at this time.
            string sSource;
            string sLog;
            string sEvent;

            sSource = "dotNET Sample App";
            sLog = "Application";
            sEvent = "Sample Event";

            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent, EventLogEntryType.Warning, 234);
        }
    }

}
