using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lab_4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_ReturnRightAddress()
        {
            string str = "http:/google.com";
            bool expected = false;

            CheckWeb check = new CheckWeb();
            check.Check(str);
        }
    }
}
