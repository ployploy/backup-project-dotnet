using System;

namespace timetracker
{
    internal class TimeTracker
    {
        TimeSpan current = DateTime.Now.TimeOfDay;
        Logger logger = new Logger();
        public TimeTracker()
        {
        }
        public TimeTracker(TimeSpan currentTime)
        {
            current = currentTime;
        }
        internal bool isOpen()
        {
            TimeSpan openTime = new TimeSpan(8, 0, 0);
            TimeSpan closeTime = new TimeSpan(17, 0, 0);

            int open = TimeSpan.Compare(current, openTime);
            int close = TimeSpan.Compare(current, closeTime);
            logger.Write(current.ToString());
            return open >= 0 && close <= 0;
        }

        internal void setLogger(Logger logger)
        {
           this.logger = logger;
        }


    }
}