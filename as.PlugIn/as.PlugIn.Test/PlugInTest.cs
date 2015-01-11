using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace @as.PlugIn.Test
{
    [TestClass]
    public class PlugInTest
    {
        [TestMethod]
        public void ConnectTest()
        {
            PlugFactory factoryOne = new Sample.One.OneFactory();
            PlugFactory factoryTwo = new Sample.One.TwoFactory();

            Console.WriteLine(
                string.Format(
                    "factoryOne : {0} - factoryTwo : {1}",
                    factoryOne.Connect().result.Count,
                    factoryTwo.Connect().result.Count
                    ));
        }
    }
}
