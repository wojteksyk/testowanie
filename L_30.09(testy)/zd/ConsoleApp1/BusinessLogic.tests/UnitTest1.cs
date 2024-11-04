namespace BusinessLogic.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 1;
            int y = 2;
            int expected = 3;
            Calculator calculator = new();

            Assert.Equal(expected, BusinessLogic.Calculator.add(x, y));

        }
        [Fact]
        public void TestSub()
        {
            int x = 10;
            int y = 5;
            int expected = 5;
            Assert.Equal(expected, BusinessLogic.Calculator.substract(x, y));
        }




        //theory przed testami zawsze!!!!
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        public void TestAddParameters(int x,int y, int expected)
            {
                Assert.Equal(BusinessLogic.Calculator.add(x,y) , expected);
            }
            [Theory]
            [InlineData(1,2,-1)]
        [InlineData(21,12,9)]
        public void TestSubstractParameters(int x, int y, int expected)
        {
            Assert.Equal(BusinessLogic.Calculator.substract(x, y), expected);
        }


    }
}