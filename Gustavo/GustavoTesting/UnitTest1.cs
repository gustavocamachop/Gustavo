using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GustavoTesting
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonalTest()
        { //organizar
            GustavoTesting.Personal obj = new GustavoTesting.PersonTests();
            string valoresperado = "Juan";
            //Ejecutar
            string valorresultado = obj.Person();
            //actuar
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveTest()
        {//organizar
            //Ejecutar
            //actuar
            Assert.Fail();
        }

        [TestMethod()]
        public void SpendTest()
        {//organizar
            //Ejecutar
            //actuar
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangeNameTest()
        {
            //organizar
            //Ejecutar
            //actuar
            Assert.Fail();
        }
    }
}
