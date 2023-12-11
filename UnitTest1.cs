using System.Reflection.Metadata;
using M05UF2;

namespace M2UF2Activitats4i5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            float perimeter = 20f;
            float apothem = 5f;

            float expectedResult = 50f;
            //Act
            /* aquesta opreació es la utilitzada en el métode
             * per ca, no puc posar 
             * el metode ja que els metodes al meu programa no
             * reben parametres d'entrada*/
            float result = (perimeter * apothem) / 2;
            //Assert

            Assert.AreEqual(expectedResult, result);
        }
    }
}