using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckStringLibrary;
using System;

namespace CheckStringLibraryTest
{
    [TestClass]
    public class CheckStringClassTests
    {
        /// <summary>
        /// Тестирование строки, состоящей только из цифр
        /// </summary>
        [TestMethod]
        public void OnlyDigits_OnlyDigit_ReturnedTrue()
        {   
            //Arrange
            string testString = "71272737938438098";

            //Act
            bool result= CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsTrue(result);
        }


        /// <summary>
        /// Тестирование пустой строки
        /// </summary>
        [TestMethod]
        public void OnlyDigits_EmptyString_ReturnedFalse()
        {
            //Arrange
            string testString = String.Empty;

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsFalse(result);
        }


        /// <summary>
        /// Тестирование строки, состоящий из цифр и букв
        /// </summary>
        [TestMethod]
        public void OnlyDigits_ContainLetters_ReturnedFalse()
        {
            //Arrange
            string testString = "123abc";

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Тестирование большого положительного числа
        /// </summary>
        [TestMethod]
        public void OnlyDigits_ContainLargeNumber_ReturnedFalse()
        {
            //Arrange
            string testString = "5555555555555";

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            try
            {
                Assert.IsTrue(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// Тестирование строки, содержащей недопутимые символы
        /// </summary>
        [TestMethod]
        public void OnlyDigits_ContainInvalidCharacter_ReturnedFalse()
        {
            //Arrange
            string testString = "jh#";

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Тестирование строки, содержащей минус
        /// </summary>
        [TestMethod]
        public void OnlyDigits_ContainMinus_ReturnedFalse()
        {
            //Arrange
            string testString = "4-4";

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsFalse(result);
        }

        ///<summary>
        /// Тестирование строки без цифр
        /// </summary>
        [TestMethod]
        public void OnlyDigits_WithoutNumbers_ReturnedFalse()
        {
            //Arrange
            string testString = ".-.";

            //Act
            bool result = CheckStringClass.OnlyDigits(testString);

            //Assert
            Assert.IsFalse(result); 
        }

    }
}
