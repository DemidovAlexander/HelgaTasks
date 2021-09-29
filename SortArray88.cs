//https://leetcode.com/problems/merge-sorted-array/submissions/
public class Solution
{
    /*static int[] SortArray(int[] arr) { //1 способ
        for (int i=0;i<arr.Length-1;i++){
            for (int j=0;j<arr.Length-1;j++){
                if (arr[j]>arr[j+1]){
                    int t=arr[j];                    
                    arr[j]=arr[j+1];
                    arr[j+1]=t;
                    
                }
            }
        }            
       return arr;   
     }*/
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        /*  SortArray(nums1);
        
        for (int i=0;i<nums1.Length;i++) {
            if (nums1[i]==0) {
                for (int j=0;j<n;j++){
                    nums1[i]=nums2[j];
                    i++;
                }                            
            break;
            }

        }
            
        
        SortArray(nums1);*/
        int[] res = new int[m + n];
        int left = 0;
        int right = 0;
        if (n == 0)
        {
            return;
        }
        for (int i = 0; i < res.Length; i++)
        {
            if (right < n && nums2[right] < nums1[left])
            {
                res[i] = nums2[right];
                right++;
            }
            else if (left < m && right < n && nums2[right] >= nums1[left])
            {
                res[i] = nums1[left];
                left++;
            }
            else if (left >= m && right < n)
            {
                res[i] = nums2[right];
                right++;
            }
            else if (right >= n && left < m)
            {
                res[i] = nums1[left];
                left++;
            }
        }
        for (int i = 0; i < res.Length; i++)
        {
            nums1[i] = res[i];
        }
    }
}
