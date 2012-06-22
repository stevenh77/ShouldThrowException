using System;

namespace TestHelperShouldThrowException
{
    class Program
    {
        public static T ShouldThrow<T>(Action action) where T : Exception
        {
            try
            {
                action();
                //Assert.Fail("Exception did not occur");
            }
            catch (T ex)
            {
                return ex;
            }
            return null;
        }

        static void Main(string[] args)
        {
        }
    }
}
