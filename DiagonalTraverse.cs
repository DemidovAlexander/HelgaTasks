
https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        

        int n=mat[0].Length;//rows
        int m=mat.Length;//cols
        int [] arr= new int [m*n];
        int k=0;
        int z=mat[0].Length;


        int r=0;
        int c=0;
        for (int d=0;d<n+m-1;d++){
            ArrayList list = new ArrayList();
            if (d<m) { r=0;}
            else { r=d-m+1;}
            
            if(d<m) { c=d;}
            else { c=m-1;}
        
        while (r<n && c>-1) {
            list.Add(mat[r][c]);
            r++;
            c--;
        }    
        if (d % 2 == 0) {
            list.Reverse();
        } 

        for (int i=0;i<list.Count;i++){
            arr[k]=(int)list[i];
            k++;
        }    
        }
       // arr[0]=n;
        return arr;
        
    }
}