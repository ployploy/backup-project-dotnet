
using System;
using System.Collections.Generic;

namespace timetracker
{
    public class MockLogger:Logger
    {
        internal int count;
        internal string lines;

        public override void Write(String lines)
        {
            this.lines = lines;
            count++ ;


        }
    }
}
