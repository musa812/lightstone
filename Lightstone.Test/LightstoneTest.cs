using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstone.Test
{
    [TestClass]
    public class LightstoneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();

            int result = calculator.Add(4, 3);

            Assert.AreEqual(7, result);
        }
    }
}
