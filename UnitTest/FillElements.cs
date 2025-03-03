using ImplementList;
namespace UnitTest
{
    [TestClass]
    public sealed class FillElements
    {
        [TestMethod]
        public void TestAddList()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");
            objects.Add("World");

            Assert.AreEqual(2, objects.Count);
            Assert.AreEqual("Hello", objects.GetItems(0));
            Assert.AreEqual("World", objects.GetItems(1));
        }

        [TestMethod]
        public void TestRemoveList()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");
            objects.Add("World");

            objects.Remove("Hello");
            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual("World", objects.GetItems(0));
        }
    }
}