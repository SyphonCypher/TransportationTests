using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TranspoTest
    {
        [Test]
        public void GetMake()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;

            //assert
            Assert.That(response, Is.EqualTo("Ford"));

        }

        [Test]
        public void GetModel()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;

            //assert
            Assert.That(response, Is.EqualTo("Bronco"));

        }

        [Test]
        public void GetColor()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetColor = "Black";
            string response = testTranspo.GetColor;

            //assert
            Assert.That(response, Is.EqualTo("Black"));

        }

        [Test]
        public void GetYear()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetYear = "1965";
            string response = testTranspo.GetYear;

            //assert
            Assert.That(response, Is.EqualTo("1965"));

        }

        [Test]
        public void GetNumWheel()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetNumWheel = "4";
            string response = testTranspo.GetNumWheel;

            //assert
            Assert.That(response, Is.EqualTo("4"));

        }

        [Test]
        public void GetEngineSize()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetEngineSize = "351";
            string response = testTranspo.GetEngineSize;

            //assert
            Assert.That(response, Is.EqualTo("351"));

        }

        [Test]
        public void GetMPH()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            int response = testTranspo.GetMPH(55);

            //assert
            Assert.That(response, Is.EqualTo(55));

        }

        [Test]
        public void GetMPG()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            int response = testTranspo.GetMPG(55, 11);

            //assert
            Assert.That(response, Is.EqualTo(605));

        }

        [Test]
        public void GetWear()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(0, 0, 0);

            //assert
            Assert.That(response, Is.EqualTo("Invalid Entry"));

        }

        [Test]
        public void GetWear_If_Miles_Divide_Heat_Is_Less_Than_50_Percent_Tread_Return_Safe()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(20, 85, 32);

            //assert
            Assert.That(response, Is.EqualTo("Unsafe"));

        }

        [Test]
        public void GetWear_If_Miles_Divide_Heat_Is_Greater_Than_50_Percent_Tread_Return_Safe()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(1500, 85, 32);

            //assert
            Assert.That(response, Is.EqualTo("Safe"));

        }



    }
}
