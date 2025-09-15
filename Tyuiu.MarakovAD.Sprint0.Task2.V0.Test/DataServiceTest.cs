using Tyuiu.MarakovAD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MarakovAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Андрей";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Андрей", res);
        }
    }
}
