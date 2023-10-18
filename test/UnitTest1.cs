using Function;

namespace test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var arr = new int[10]
        {
            2,5,3,4,7,9,0,1,6,8
        };
        Functions.SortRevers(ref arr);
        CollectionAssert.AreEqual(arr, new int[10] {9,8,7,6,5,4,3,2,1,0});
    }
}