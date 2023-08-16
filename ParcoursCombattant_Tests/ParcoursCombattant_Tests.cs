using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcoursCombattant_Affaires;

namespace ParcoursCombattant_Tests
{
    [TestClass]
    public class ParcoursCombattant_Tests
    {
        [TestMethod]
        public void ValiderProblemes_Tests()
        {
            C x = new C(1, 4, 10);
            // COMPLÉTER LES VALEURS ATTENDUES
            Assert.AreEqual(0, x.determinerHandicap());
            Assert.AreEqual(0, x.ValeurA);
            Assert.AreEqual(0, x.ValeurB);
            Assert.AreEqual(0, x.ValeurC);
            Assert.AreEqual(0, x.calculer());

            B y = new B(6, 7, 1);
            // COMPLÉTER LES VALEURS ATTENDUES
            Assert.AreEqual(0, y.determinerHandicap());
            Assert.AreEqual(0, y.calculer());
        }
    }
}
