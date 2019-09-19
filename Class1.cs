using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input4and56_Returns60()
            {
                //Arrange
                double number1 = 4;
                double number2 = 56;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetAddition(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input4and6_Returns10()
            {
                //Arrange
                double number1 = 4;
                double number2 = 6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetAddition(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input3and8_Returns11()
            {
                //Arrange
                double number1 = 3;
                double number2 = 8;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetAddition(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
           
            [Test]
            public void GetSubstraction_Input74and56_Returns18()
            {
                //Arrange
                double number1 = 74;
                double number2 = 56;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetSubtraction(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubstraction_Input94and86_Returns8()
            {
                //Arrange
                double number1 = 94;
                double number2 = 86;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetSubtraction(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubstraction_Input104and82_Returns22()
            {
                //Arrange
                double number1 = 104;
                double number2 = 82;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetSubtraction(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input94and76_Returns18()
            {
                //Arrange
                double number1 = 94;
                double number2 = 76;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetMultiplication(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input54and26_Returns28()
            {
                //Arrange
                double number1 = 54;
                double number2 = 26;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetMultiplication(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input24and7_Returns17()
            {
                //Arrange
                double number1 = 24;
                double number2 = 7;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetMultiplication(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input4_Returns2()
            {
                //Arrange
                double number1 = 4;
                double number2 =2;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetDivision(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivision_Input8point4and6point6_Returns1point27()
            {
                //Arrange
                double number1 = 8.4;
                double number2 = 6.6;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetDivision(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivision_Input78point4and3point6_Returns21point78()
            {
                //Arrange
                double number1 = 78.4;
                double number2 = 3.6;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2); //Act
                double actualResult = testCalc.GetDivision(); //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        }

    }
}
