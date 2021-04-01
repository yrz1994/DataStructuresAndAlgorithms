using LeetCode.Core;
using Xunit;

namespace LeetCode.UnitTest
{
    public class ThreeSumUnitTest
    {
        [Fact]
        public void ThreeSumTest1()
        {
            //Arrange
            var sut = new ThreeSum(); //sut: system under test
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            //Act
            var result = sut.GetThreeSum(nums);

            //Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void ThreeSumTest2()
        {
            //Arrange
            var sut = new ThreeSum(); //sut: system under test
            var nums = new int[] { 0, 0, 0, 0 };

            //Act
            var result = sut.GetThreeSum(nums);

            //Assert
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void ThreeSumTest3()
        {
            //Arrange
            var sut = new ThreeSum(); //sut: system under test
            var nums = new int[] { 1, -1, -1, 0 };

            //Act
            var result = sut.GetThreeSum(nums);

            //Assert
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void ThreeSumTest4()
        {
            //Arrange
            var sut = new ThreeSum(); //sut: system under test
            var nums = new int[] { 34, 55, 79, 28, 46, 33, 2, 48, 31, -3, 84, 71, 52, -3, 93, 15, 21, -43, 57, -6, 86, 56, 94, 74, 83, -14, 28, -66, 46, -49, 62, -11, 43, 65, 77, 12, 47, 61, 26, 1, 13, 29, 55, -82, 76, 26, 15, -29, 36, -29, 10, -70, 69, 17, 49 };

            //Act
            var result = sut.GetThreeSum(nums);

            //Assert
            Assert.Equal(43, result.Count);
        }

        [Fact]
        public void ThreeSumTest5()
        {
            //Arrange
            var sut = new ThreeSum(); //sut: system under test
            var nums = new int[] { 82597, -9243, 62390, 83030, -97960, -26521, -61011, 83390, -38677, 12333, 75987, 46091, 83794, 19355, -71037, -6242, -28801, 324, 1202, -90885, -2989, -95597, -34333, 35528, 5680, 89093, -90606, 50360, -29393, -27012, 53313, 65213, 99818, -82405, -41661, -3333, -51952, 72135, -1523, 26377, 74685, 96992, 92263, 15929, 5467, -99555, -43348, -41689, -60383, -3990, 32165, 65265, -72973, -58372, 12741, -48568, -46596, 72419, -1859, 34153, 62937, 81310, -61823, -96770, -54944, 8845, -91184, 24208, -29078, 31495, 65258, 14198, 85395, 70506, -40908, 56740, -12228, -40072, 32429, 93001, 68445, -73927, 25731, -91859, -24150, 10093, -60271, -81683, -18126, 51055, 48189, -6468, 25057, 81194, -58628, 74042, 66158, -14452, -49851, -43667, 11092, 39189, -17025, -79173, 13606, 83172, 92647, -59741, 19343, -26644, -57607, 82908, -20655, 1637, 80060, 98994, 39331, -31274, -61523, 91225, -72953, 13211, -75116, -98421, -41571, -69074, 99587, 39345, 42151, -2460, 98236, 15690, -52507, -95803, -48935, -46492, -45606, -79254, -99851, 52533, 73486, 39948, -7240, 71815, -585, -96252, 90990, -93815, 93340, -71848, 58733, -14859, -83082, -75794, -82082, -24871, -1 };

            //Act
            var result = sut.GetThreeSum(nums);

            //Assert
            Assert.Equal(3, result.Count);
        }
    }
}
