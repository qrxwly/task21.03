using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1_exp = double.NaN, x2_exp = double.NaN, d_exp = double.NaN;
            string message_exp = "Прямая совпадает с осью, ответ R";

            double x1_act, x2_act, d_act;
            string message_act;

            KU.KvadrUr (0, 0, 0, out d_act, out x1_act, out x2_act, out message_act);

            Assert.AreEqual(d_exp, d_act);
            Assert.AreEqual(x1_exp, x1_act);
            Assert.AreEqual(x2_exp, x2_act);
            Assert.AreEqual(message_exp, message_act);
        }
    }
}
