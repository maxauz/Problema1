using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testeo
{
    [TestClass]
    public class testear
    {
        [TestMethod]
        public void TestMethod1()
        {const string input="123 abcd*3";
        const string output = "123 bcde*3";

        string resultado=Consola.ChangeString.build(input);

        Assert.AreEqual(resultado,output);
        }
          [TestMethod]
        public void TestMethod2()
        {
            const string input = "**Casa 52";
            const string output = "**Dbtb 52";

            string resultado = Consola.ChangeString.build(input);

            Assert.AreEqual(resultado, output);
        }
    }
}
