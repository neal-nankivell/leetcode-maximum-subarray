using NUnit.Framework;
using Answer;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(-2, 1, -3, 4, -1, 2, 1, -5, 4, ExpectedResult = 6)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(-1, 1, ExpectedResult = 1)]
        [TestCase(1, -1, ExpectedResult = 1)]
        public int MaxSubArray(params int[] nums)
        {
            var sut = new Solution();

            return sut.MaxSubArray(nums);
        }
    }
}