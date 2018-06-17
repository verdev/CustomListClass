using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_String_Value_To_Custom_List_Checks_Count()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = "hello";
            int expectedCount = 1;
            
            //Act
            customList.Add(inputValue);
            int actualCount = customList.Counter;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Check_Value_At_Index_0()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string inputValue = "hello";
            string expectedValue = "hello";

            //Act
            customList.Add(inputValue);
            string actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
