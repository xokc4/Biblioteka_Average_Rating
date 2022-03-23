using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteka_Average_Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Average_Rating.Tests
{
    [TestClass()]
    public class ClassAverageRatingTests
    {
        [TestMethod()]
        public void MethodRatingTest_Otrizat_otvet()
        {
            int idStud = -1;
            int idDis = -1;
            int ex = -1;
            var otvet = ClassAverageRating.MethodRating(idStud, DateTime.Now, DateTime.Now, idDis);
            Assert.AreEqual(ex, otvet);
        }
        [TestMethod()]
        public void MethodRatingTest_Date()
        {
            int idStud = 1;
            int idDis = 1;
            DateTime dateStart = new DateTime(2021,11,15);
            DateTime dateEnd = new DateTime(2021, 12, 15);
            int ex = -1;
            var otvet = ClassAverageRating.MethodRating(idStud, DateTime.Now, DateTime.Now, idDis);
            Assert.AreEqual(ex, otvet);
        }
        [TestMethod()]
        public void MethodRatingTest_polosh_Otvet()
        {
            int idStud = 1;
            int idDis = 1;
            int ex = 1;
            var otvet = ClassAverageRating.MethodRating(idStud, DateTime.Now, DateTime.Now, idDis);
            Assert.AreEqual(ex, otvet);
        }
        [TestMethod()]
        public void MethodRatingTest_odno_iz_4isel_otriz_1()
        {
            int idStud = -1;
            int idDis = 1;
            int ex = -1;
            var otvet = ClassAverageRating.MethodRating(idStud, DateTime.Now, DateTime.Now, idDis);
            Assert.AreEqual(ex, otvet);
        }
        [TestMethod()]
        public void MethodRatingTest_odno_iz_4isel_otriz_2()
        {
            int idStud = 1;
            int idDis = -1;
            int ex = -1;
            var otvet = ClassAverageRating.MethodRating(idStud, DateTime.Now, DateTime.Now, idDis);
            Assert.AreEqual(ex, otvet);
        }
        [TestMethod()]
        public void MethodRatingTest_Date_Final()
        {
            int idStud = 2;
            int idDis = 3;
            DateTime dateStart = new DateTime(2021, 01, 01, 12, 05, 00);
            DateTime dateEnd = new DateTime(2021, 03, 05, 7, 05, 00);
            double ex = 2.5;
            var otvet = ClassAverageRating.MethodRating(idStud, dateStart, dateEnd, idDis);
            Assert.AreEqual(ex, otvet);
        }

    }
}