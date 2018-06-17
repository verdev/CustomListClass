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
        [TestMethod]
        public void Add_Int_Values_To_Custom_List_Checks_Count()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index0 = 5;
            int index1 = 3;
            int index2 = 1;
            int expectedValue = 3;
            int actualValue;

            //Act
            customList.Add(index0);
            customList.Add(index1);
            customList.Add(index2);
            actualValue= customList.Counter;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Check_Value_At_Index_2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index0 = 5;
            int index1 = 3;
            int index2 = 1;
            int expectedValue = 1;
            int actualValue;

            //Act
            customList.Add(index0);
            customList.Add(index1);
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
    }
}
