using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarrefourEssert;

namespace TestUnititaire
{
    [TestClass]
    public class TestUnitaireClass
    {
        double posX = 23.4;
        double posY = 43.2;
        Usager u;

        /***************************************
        ***************** Route ****************
        ***************************************/
        [TestMethod]
        public void TestRouteCtor()
        {
            //A remplir

            Route target = new Route("Nord", "Voiture", 1, posX, posY);

            // Act

            // Assert
            Assert.AreEqual("Nord", target.Sens);
            Assert.AreEqual("Voiture", target.Type);
            Assert.AreEqual(1, target.NbVoie);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        }

        /***************************************
        ************ PassagePieton *************
        ***************************************/
        [TestMethod]
        public void TestPassagePietonCtor()
        {
            //A remplir 
            PassagePieton target = new PassagePieton();

            // Act

            // Assert
            Assert.AreEqual("Nord", "");
        }

        /***************************************
        ************** Véhicules ***************
        ***************************************/
        [TestMethod]
        public void TestBusAvancer()
        {
            //A remplir 
            Bus target = new Bus(6, 7.5, "GE-BUS", "rouge", "SacDos", posX, posY);
            u = target;
            // Act
            target.Avancer(u);

            // Assert
            Assert.AreNotEqual(43.2, target.PosY);
        }
        [TestMethod]
        public void TestBusFreiner()
        {
            //A remplir 
            Bus target = new Bus(6, 7.5, "GE-BUS", "rouge", "SacDos", posX, posY);
            u = target;
            // Act
            target.Avancer(u);
            if (target.PosY > 43.2)
            {
                target.Freiner(u);
            }

            // Assert
            Assert.AreEqual(44.2, target.PosY);
        }


        [TestMethod]
        public void TestBusCtor()
        {
            //A remplir

            Bus target = new Bus(6, 7.5, "GE-BUS", "rouge", "SacDos", posX, posY);

            // Act

            // Assert
            Assert.AreEqual(6, target.NbRoues);
            Assert.AreEqual(7.5, target.Taille);
            Assert.AreEqual("GE-BUS", target.Immatriculation);
            Assert.AreEqual("rouge", target.Couleur);
            Assert.AreEqual("SacDos", target.Marque);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        }
         
        [TestMethod]
        public void TestMotoCtor()
        {
            //A remplir

            Moto target = new Moto(6, 7.5, "GE-ROULE", "orange", "SacDos", posX, posY);

            // Act

            // Assert
            Assert.AreEqual(6, target.NbRoues);
            Assert.AreEqual(7.5, target.Taille);
            Assert.AreEqual("GE-ROULE", target.Immatriculation);
            Assert.AreEqual("orange", target.Couleur);
            Assert.AreEqual("SacDos", target.Marque);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        }
         
        [TestMethod]
        public void TestTramCtor()
        {
            //A remplir

            Tram target = new Tram(6, 7.5, "GE-TRAM", "roouououuge", "SacDos", posX, posY);

            // Act

            // Assert
            Assert.AreEqual(6, target.NbRoues);
            Assert.AreEqual(7.5, target.Taille);
            Assert.AreEqual("GE-TRAM", target.Immatriculation);
            Assert.AreEqual("roouououuge", target.Couleur);
            Assert.AreEqual("SacDos", target.Marque);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        } 

        [TestMethod]
        public void TestVeloCtor()
        {
            //A remplir

            Velo target = new Velo(6, 7.5, "GE-VELO", "BLANCCCCCCCCCCCCCCC", "SacDos", posX, posY);

            // Act

            // Assert
            Assert.AreEqual(6, target.NbRoues);
            Assert.AreEqual(7.5, target.Taille);
            Assert.AreEqual("GE-VELO", target.Immatriculation);
            Assert.AreEqual("BLANCCCCCCCCCCCCCCC", target.Couleur);
            Assert.AreEqual("SacDos", target.Marque);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        }

        [TestMethod]
        public void TestVoitureCtor()
        {
            //A remplir

            Voiture target = new Voiture(6, 7.5, "GE-POLUE", "violet", "SacDos", posX, posY);

            // Act

            // Assert
            Assert.AreEqual(6, target.NbRoues);
            Assert.AreEqual(7.5, target.Taille);
            Assert.AreEqual("GE-POLUE", target.Immatriculation);
            Assert.AreEqual("violet", target.Couleur);
            Assert.AreEqual("SacDos", target.Marque);
            Assert.AreEqual(23.4, target.PosX);
            Assert.AreEqual(43.2, target.PosY);
        }
    }
}
