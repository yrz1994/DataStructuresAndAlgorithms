namespace LeetCode.Core
{
    //LC.4 寻找两个正序数组的中位数
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            var len = nums1.Length + nums2.Length;
            var array = new int[(len / 2) + 1];
            for (int k = 0; k < array.Length; k++)
            {
                if (nums2.Length == j || i < nums1.Length && nums1[i] <= nums2[j])
                {
                    array[k] = nums1[i];
                    i++;
                }
                else
                {
                    array[k] = nums2[j];
                    j++;
                }
            }
            return len % 2 == 0 ? (array[array.Length - 1] + array[array.Length - 2]) / 2.0 : array[array.Length - 1];
        }
    }
}
