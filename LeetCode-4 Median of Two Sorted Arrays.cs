public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len1 = nums1.Length;
        int len2 = nums2.Length;
        
        int[] mergedArr = new int[len1+len2];
        int i =0,j=0,count=0;
            while(i<len1 && j<len2)
            {
                if(nums1[i] < nums2[j])
                {
                    mergedArr[count] = nums1[i];
                    i++;
                }
                else
                {
                    mergedArr[count] = nums2[j];
                    j++;
                }
                count++;
            }
            
            while(i<len1)
            {
                mergedArr[count] = nums1[i];
                i++;
                count++;
            }
            while(j<len2)
            {
                mergedArr[count] = nums2[j];
                j++;
                count++;
            }
             
        int cen1 = (mergedArr.Length/2)-1;
        int cen2 = mergedArr.Length/2;
        
        Console.WriteLine("Centers {0},{1}", cen1,cen2);
        
        if(mergedArr.Length%2 ==0)
        {
            Console.WriteLine("am here {0}",mergedArr[cen1] +mergedArr[cen2]);
            return Convert.ToDouble((mergedArr[cen1] +mergedArr[cen2]))/2;
        }
        else
            return Convert.ToDouble(mergedArr[cen2]);        
        
    }
}