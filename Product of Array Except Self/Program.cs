public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            List<int> list = new List<int>(nums);
            list.RemoveAt(i);
            //Console.WriteLine(",", list);
            var mult = list.Aggregate((x, y) => x * y);
            answer[i] = mult;
        }
        return answer;
    }

    public int[] ProductExceptSelf2(int[] nums)
    {
        int[] answer = new int[nums.Length];
        int preV = 1;
        int postV = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = preV;
            preV *= nums[i];
        }
        for (int i = nums.Length -1; i >= 0 ; i--)
        {
            answer[i] *= postV;
            postV *= nums[i];
        }

        return answer;
    }

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };
        //int[] nums = { -1,1,0,-3,3 };
        Solution solution = new Solution();
        int[] res = solution.ProductExceptSelf2(nums);

        Console.WriteLine(string.Join(",", res));
    }
}