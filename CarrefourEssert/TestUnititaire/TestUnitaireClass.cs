using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnititaire
{
    [TestClass]
    public class TestUnitaireClass
    {
        /***************************************
        **************** Routes ****************
        ***************************************/
        [TestMethod]
        public void TestClassRoutes()
        {
            //A remplir

            Route target = new Route();

            // Act
            double map = target.mapExist;

            // Assert
            Assert.AreEqual(1, map); 

            throw new NotImplementedException();
        }

        /***************************************
        ***************** Feu ******************
        ***************************************/
        [TestMethod]
        public void TestClassFeu()
        {
            //A remplir

            Feu target = new Feu();

            // Act
            int feu = target.isVert;

            // Assert
            Assert.AreEqual(1, feu);

            throw new NotImplementedException();
        }

        /***************************************
        *************** Véhicule ***************
        ***************************************/
        [TestMethod]
        public void TestClassVehicule()
        {
            //A remplir

            Vehicule target = new Vehicule();

            // Act
            string vehicule = target.isVehicule;

            // Assert
            Assert.AreEqual("vehicule", vehicule);

            throw new NotImplementedException();
        }

        /***************************************
        ***************** Tram *****************
        ***************************************/
        [TestMethod]
        public void TestClassTram()
        {
            //A remplir

            Tram target = new Tram();

            // Act
            string Tram = target.isTram;

            // Assert
            Assert.AreEqual("Tram", Tram);

            throw new NotImplementedException();
        }

        /***************************************
        ***************** Moto *****************
        ***************************************/
        [TestMethod]
        public void TestClassMoto()
        {
            //A remplir

            Moto target = new Moto();

            // Act
            string vehicule = target.isMoto;

            // Assert
            Assert.AreEqual("Moto", Moto);

            throw new NotImplementedException();
        }

        /***************************************
        ***************** Velo *****************
        ***************************************/
        [TestMethod]
        public void TestClassVelo()
        {
            //A remplir

            Velo target = new Velo();

            // Act
            string velo = target.isVelo;

            // Assert
            Assert.AreEqual("Velo", Velo);

            throw new NotImplementedException();
        }

        /***************************************
        **************** Voiture ***************
        ***************************************/
        [TestMethod]
        public void TestClassVoiture()
        {
            //A remplir

            Voiture target = new Voiture();

            // Act
            string voiture = target.isVoiture;

            // Assert
            Assert.AreEqual("Voiture", Voiture);

            throw new NotImplementedException();
        }

        /***************************************
        ****************** Bus *****************
        ***************************************/
        [TestMethod]
        public void TestClassBus()
        {
            //A remplir

            Bus target = new Bus();

            // Act
            string Bus = target.isBus;

            // Assert
            Assert.AreEqual("Bus", Bus);

            throw new NotImplementedException();
        } 
    }
}
