// See https://aka.ms/new-console-template for more information
// foreach (var item in RowIndex(3))
// {
//     System.Console.WriteLine(item);
// }



//Question1
 static int[] RowIndex(int rowIndex)
 {
    var n = 11;
    var pascal = Math.Pow(n,rowIndex);
    var result = pascal.ToString().ToCharArray().Select(a => Convert.ToInt32(a.ToString())).ToArray();
    return result;
       
 }
 //question 2
 static int ReturnMajorityElement(int[] ints)
 {
    int max = 0, save = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        var check = Check(ints,ints[i]);
        if(check > max) 
        {
            max = check;
            save = ints[i];
        }
    }
    var result = (ints.Length/2) > (max)? ints.Length/2 : max;
    return save;
 }
  static int Check(int [] arr, int num)
  {
    var count = arr.Count(a => a == num);
    return count;
  }
