using System;
using Xunit;

namespace timetracker
{
    public class TimetarckerTest
    {
        [Fact]
        public void when8_should_isOpen()
        {
            TimeTracker time = new TimeTracker(new TimeSpan(8,0,0));
            bool expected = true;
            bool actual = time.isOpen();
            Assert.Equal(expected,actual);

        }

        [Fact]
        public void when1701_should_isClose()
        {
            TimeTracker time = new TimeTracker(new TimeSpan(17,0,1));
            bool expected = false;
            bool actual = time.isOpen();
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void whenTimeSpanShouldEqual0()
        {
            TimeSpan t1 = new TimeSpan(8,9,50);
            TimeSpan t2 = new TimeSpan(8,9,50);
            int expected = 0;
            int actual = TimeSpan.Compare(t1,t2);
             Assert.Equal(expected,actual);
            
            
        }

        [Fact]
        public void whenTimeSpanShouldlittleReturn1()
        {
            TimeSpan t1 = new TimeSpan(9,0,0);
            TimeSpan t2 = new TimeSpan(8,0,0);

            int expected = 1;
            int actual = TimeSpan.Compare(t1,t2);
            Assert.Equal(expected,actual);

        }
        
        [Fact]
        public void whenTimeSpanShouldlittleReturn2()
        {
            TimeSpan t1 = new TimeSpan(8,0,0);
            TimeSpan t2 = new TimeSpan(9,0,0);

            int expected = -1;
            int actual = TimeSpan.Compare(t1,t2);
            Assert.Equal(expected,actual);

        }

          
        [Fact]
        public void gatterthanAndEqual()
        {
            TimeSpan t1 = new TimeSpan(8,0,0);
            TimeSpan t2 = new TimeSpan(8,0,0);

            int expected = 0;
            int actual = TimeSpan.Compare(t1,t2);
            Assert.True(actual >= expected);

        }

           [Fact]
        public void littlethanAndEqual()
        {
            TimeSpan t1 = new TimeSpan(8,0,0);
            TimeSpan t2 = new TimeSpan(17,0,0);

            int expected = -1;
            int actual = TimeSpan.Compare(t1,t2);
            Assert.Equal(expected,actual);

        }
        [Fact]
        public void checkCalled()
        {
            TimeTracker time = new TimeTracker();
            MockLogger logger = new MockLogger();
            time.setLogger(logger);

            time.isOpen();
            
            Assert.Equal(1,logger.count);
        }

        [Fact]
         public void checkCalledwithExpected()
        {
            TimeTracker time = new TimeTracker(new TimeSpan(17,0,0));
            MockLogger logger = new MockLogger();
            time.setLogger(logger);

            time.isOpen();
            
            Assert.Equal(new TimeSpan(17,0,0).ToString(),logger.lines);
        }

    }
}
