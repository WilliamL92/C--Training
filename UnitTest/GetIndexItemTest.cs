using ImplementList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class GetIndexItemTest
    {
        [TestMethod]
        public void GetOneItemByIndexTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");

            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual("Hello", objects.GetItem(0));
        }

        [TestMethod]
        public void GetThreeItemByIndexTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("First");
            objects.Add("Second");
            objects.Add("Third");
            objects.Add("Four");
            objects.Add("Five");

            Assert.AreEqual(5, objects.Count);
            Assert.AreEqual("First", objects.GetItem(0));
            Assert.AreEqual("Second", objects.GetItem(1));
            Assert.AreEqual("Third", objects.GetItem(2));
        }

        [TestMethod]
        public void GetItemByIndexAfterRemoveTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("First");
            objects.Add("Second");
            objects.Add("Third");
            objects.Add("Four");
            objects.Add("Five");

            objects.Remove("Five");

            Assert.AreEqual(4, objects.Count);
            Assert.AreEqual("Four", objects.GetItem(objects.Count-1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetItemByIfIndexNotExistTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("First");
            objects.Add("Second");
            objects.Add("Third");
            objects.Add("Four");
            objects.Add("Five");

            objects.Remove("Five");

            Assert.AreEqual(4, objects.Count);
            objects.GetItem(99);
        }
    }
}
