using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnitTestSample.Domain;
using NUnitTestSample.Domain.Contracts;
using NUnitTestSample.FakeRepository;
using System;
using Assert = NUnit.Framework.Assert;

namespace NUnitTestSample
{
    [TestClass]
    public class Dada_uma_nova_sala
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void O_nome_deve_ser_sala_1()
        {
            //Assert.Pass();

            var room = new Room("Sala 2");
            room.Name = "Sala 2";

            Assert.AreEqual("Sala 1", room.Name);
            //Assert.Pass();
            //Assert.Fail();

        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_ser_fornecido()
        {
            //Assert.Pass();

            var room = new Room("Sala 1");

            //Assert.Pass();
            //Assert.Fail();

        }

       
    }

    [TestClass]
    public class Data_nova_reserva
    {

        [Test]
        public void O_sala_deve_estar_disponivel()
        {

            IBookRepository rep = new BookFakeRepository();

            //Assert.Pass();

            var startDate = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);

            var room = new Room("Sala 1");

            room.Book(startDate, endDate, rep.GetByDate(startDate, endDate));
            //Assert.Pass();
            //Assert.Fail();

        }

    }
}