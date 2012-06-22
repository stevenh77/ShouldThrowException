using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelperShouldThrowException.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GivenConstructorWhenNameIsFiveCharactersThenPersonIsCreated()
        {
            Person person = new Person("Tommy");
            Assert.IsNotNull(person);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenConstructorWhenNameIsEmptyThenArgumentExceptionThrown()
        {
            Person person = new Person("");
        }

        [TestMethod]
        public void GivenConstructoWhenNameIsEmptyThenArgumentExceptionThrownUpdated()
        {
            Helper.ShouldThrowException<ArgumentException>(() => new Person(""));
        }
    }
}
