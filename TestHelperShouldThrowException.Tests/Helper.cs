using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelperShouldThrowException.Tests
{
    class Helper
    {
        public static void ShouldThrowException<T>(Action action) where T : Exception
        {
            try
            {
                action();
            }
            catch (T)
            {
                return;
            }

            Assert.Fail("Exception did not occur");
        }
    }
}
