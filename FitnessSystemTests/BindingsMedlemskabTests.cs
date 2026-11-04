using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessSystemTestØvelse;

namespace FitnessSystemTests
{
    [TestClass]
    public class BindingsMedlemskabTests
    {
        [TestMethod]
        public void TC1()
        {
            Assert.ThrowsExactly<ArgumentException>(() =>
            {
                new BindingsMedlemskab(
                    start: new DateTime(2026, 1, 15),
                    slut: new DateTime(2026, 1, 14),
                    bindingsMåneder: 6);
            });
        }

        [TestMethod]
        public void TC2()
        {
            BindingsMedlemskab sut = new BindingsMedlemskab(
                start: new DateTime(2026, 1, 15),
                slut: new DateTime(2026, 1, 15),
                bindingsMåneder: 6);

            double result = sut.BeregnSamletPris();

            Assert.AreEqual(650.0, result);
        }

        [TestMethod]
        public void TC3()
        {
            BindingsMedlemskab sut = new BindingsMedlemskab(
                start: new DateTime(2026, 1, 15),
                slut: new DateTime(2026, 3, 15),
                bindingsMåneder: 6);

            double result = sut.BeregnSamletPris();

            Assert.AreEqual(950.0, result);
        }

        [TestMethod]
        public void TC4()
        {
            BindingsMedlemskab sut = new BindingsMedlemskab(
                start: new DateTime(2026, 1, 15),
                slut: new DateTime(2026, 7, 14),
                bindingsMåneder: 6);

            double result = sut.BeregnSamletPris();

            Assert.AreEqual(1400.0, result);
        }

        [TestMethod]
        public void TC5()
        {
            BindingsMedlemskab sut = new BindingsMedlemskab(
                start: new DateTime(2026, 1, 15),
                slut: new DateTime(2026, 7, 15),
                bindingsMåneder: 6);

            double result = sut.BeregnSamletPris();

            Assert.AreEqual(1050.0, result);
        }

        [TestMethod]
        public void TC6()
        {
            BindingsMedlemskab sut = new BindingsMedlemskab(
                start: new DateTime(2026, 1, 15),
                slut: new DateTime(2026, 7, 16),
                bindingsMåneder: 6);

            double result = sut.BeregnSamletPris();

            Assert.AreEqual(1050.0, result);
        }
    }
}