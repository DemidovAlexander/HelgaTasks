//https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1162/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int min=0;
        for (int i=1;i<strs.Length;i++){
            if (strs[i].Length<strs[min].Length){
                min=i;
            }
        }
        char[] minArr=strs[min].ToCharArray();
        int prefix=minArr.Length;
        for (int i=0;i<strs.Length;i++){
          char[] str=strs[i].ToCharArray();  
          for (int j=0; j<prefix;j++){
              if(minArr[j]!=str[j]){
                if (j==0) {return "";}  
                prefix=j;                
              }
          }      
        }
 
        string result=strs[min].Substring(0,prefix);
        return result;
        
    }
}