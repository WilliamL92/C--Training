using ImplementList;
namespace UnitTest
{
    [TestClass]
    public class AddItem
    {
        [TestMethod]
        public void AddSingleStringTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");

            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual("Hello", objects.GetItem(0));
        }

        [TestMethod]
        public void MultipleAddStringsTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");
            objects.Add("World");
            objects.Add("Heyyy");

            Assert.AreEqual(3, objects.Count);
            Assert.AreEqual("Hello", objects.GetItem(0));
            Assert.AreEqual("World", objects.GetItem(1));
            Assert.AreEqual("Heyyy", objects.GetItem(2));
        }
    }
}