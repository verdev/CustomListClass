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
            CustomList<string> customList = new CustomList<string>() { "You're", "A", "Good", "Choice" };
            string inputValue = "To Choose";
            int expectedCount = 5;
            
            //Act
            customList.Add(inputValue);
            int actualCount = customList.Counter;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Check_Value_At_Index_3()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "You're", "A", "Good", "Choice" };
            string inputValue = "To Choose";
            string expectedValue = "Choice";

            //Act
            customList.Add(inputValue);
            string actualValue = customList[3];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_Values_To_Custom_List_Checks_Count()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 5, 3 };
            int index2 = 1;
            int expectedValue = 3;
            int actualValue;

            //Act
            customList.Add(index2);
            actualValue= customList.Counter;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Check_Value_At_Index_2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 5, 3 };
            int index2 = 1;
            int expectedValue = 1;
            int actualValue;

            //Act
            customList.Add(index2);
            actualValue = customList[2];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Check_Value_At_Index_4_Using_Object_Datatype()
        {
            //Arrange
            CustomList<object> customList = new CustomList<object>();
            string index0 = "index0";
            bool index1 = true;
            string index2 = "index2";
            double index3 = 3.82543;
            ulong index4 = 18446744073709551615;
            ulong expectedValueIndex4 = 18446744073709551615;
            object actualValueIndex4;

            //Act
            customList.Add(index0);
            customList.Add(index1);
            customList.Add(index2);
            customList.Add(index3);
            customList.Add(index4);
            actualValueIndex4 = customList[4];

            //Assert
            Assert.AreEqual(expectedValueIndex4, actualValueIndex4);
        }
        [TestMethod]
        public void Remove_String_Value_From_Custom_List_Checks_Removed_Index_Value()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "You're", "A", "Good", "Choice" };
            string deleteValue = "You're";
            string expectedValue = "A";

            //Act
            customList.Remove(deleteValue);
            string actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Test_Custom_To_String_Method()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "You're", "A", "Good", "Choice", "To", "Choose" };
            string expectedValue = "You're A Good Choice To Choose ";

            //Act
            string actualValue = customList.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
