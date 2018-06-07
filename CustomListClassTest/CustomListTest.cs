using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_String_Value_To_Custom_List()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = "hello";
            int expectedCount = 1;
            
            //Act
            customList.Add(inputValue);
            int actualCount = customList.arrCount;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
