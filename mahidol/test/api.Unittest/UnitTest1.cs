using System;
using Xunit;
using api.Services;

namespace api.Unittest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(1);

            Assert.Equal("1",accual);
        }

        [Fact]
         public void Test2()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(2);

            Assert.Equal("2",accual);
        }

        [Fact]
         public void Test3()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(3);

            Assert.Equal("Fizz",accual);
        }

        [Fact]
         public void Test5()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(5);

            Assert.Equal("Buzz",accual);
        }

        [Fact]
         public void Test10()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(10);

            Assert.Equal("Buzz",accual);
        }

        [Fact]
         public void Test15()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string accual = fizzbuzz.say(15);

            Assert.Equal("FizzBuzz",accual);
        }

    }
}
