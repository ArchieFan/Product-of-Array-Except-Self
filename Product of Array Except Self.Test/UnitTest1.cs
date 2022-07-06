namespace Product_of_Array_Except_Self.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0  })]

        public void Test1(int[] nums, int[] expected)
        {
            //int[] nums = { 1, 2, 3, 4 };
            //int[] nums = { -1,1,0,-3,3 };
            Solution solution = new Solution();
            int[] res = solution.ProductExceptSelf(nums);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        public void Test2(int[] nums, int[] expected)
        {
            //int[] nums = { 1, 2, 3, 4 };
            //int[] nums = { -1,1,0,-3,3 };
            Solution solution = new Solution();
            int[] res = solution.ProductExceptSelf2(nums);
            Assert.Equal(expected, res);
        }
    }
}