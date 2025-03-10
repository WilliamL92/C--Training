using ImplementList;
namespace UnitTest
{
    [TestClass]
    public class AddItemAddItem
    {
        [TestMethod]
        public void AddItemListTest()
        {
            MyList<string> objects = new MyList<string>();
            objects.Add("Hello");

            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual("Hello", objects.GetItem(0));
        }

        [TestMethod]
        public void MultipleAddItemsListTest()
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