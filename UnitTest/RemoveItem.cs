using ImplementList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class RemoveItem
    {
        [TestMethod]
        public void RemoveOneItemTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");
            objects.Add("World");

            bool result = objects.Remove("Hello");
            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual("World", objects.GetItem(0));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemoveThreeItemsTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Athoria");
            objects.Add("is");
            objects.Add("a");
            objects.Add("Company");
            objects.Add("in");
            objects.Add("Paris");

            objects.Remove("Paris");
            objects.Remove("is");
            objects.Remove("in");
            Assert.AreEqual(3, objects.Count);
            Assert.AreEqual("Company", objects.GetItem(2));
        }

        [TestMethod]
        public void RemoveUnusuedItemTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Athoria");
            objects.Add("is");
            objects.Add("a");
            objects.Add("Company");
            objects.Add("in");
            objects.Add("Paris");

            bool result = objects.Remove("Heyy");
            Assert.AreEqual(6, objects.Count);
            Assert.AreEqual("Paris", objects.GetItem(5));
            Assert.IsFalse(result);
        }
    }
}
