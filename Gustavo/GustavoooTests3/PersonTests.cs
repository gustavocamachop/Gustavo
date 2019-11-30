using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gustavooo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gustavooo.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest()
        {//organizar
            Person account = new Person("jose", 1000);

            //Ejecutar

            //actuar

        }


        [TestMethod()]
        public void ChangeNameTest()
        {//organizar
            Person account = new Person("jose", 1000);
            string ve = "jose";
            //Ejecutar
            string vr = account.ChangeName(ve);
            //actuar
            Assert.AreEqual(ve, vr);
        }

        [TestMethod()]
        public void SaveTest()
        {//organizar
            Person account = new Person("juan", 0);
            double ve = 2000;
            //Ejecutar
            double vr = account.Save(2000);
            //actuar
            Assert.AreEqual(ve, vr);
        }

        [TestMethod()]
        public void SpendTest()
        {
            Person account = new Person("juan", 3000);
            double ve = 2000;
            //Ejecutar
            double vr = account.Save(1000);
            //actuar
            Assert.AreEqual(ve, vr);
        }
    }
}