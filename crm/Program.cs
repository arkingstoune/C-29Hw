//first one 
int[] SomeArray = new int[] {1,2,8,-3,-5,4,98,4,-5,5,-6,6,4,2};
var SomeArray1 = SomeArray.Order();
var SortedIntArray = 
    from numb in SomeArray1
    where numb % 2 is 0   
     select numb;
// foreach(var bone in SortedIntArray)
// {
//     Console.WriteLine(bone);
// }

//Second one 
string[] SomeArrayOfString = new string[]{"slk","sldf","nope","yes","open","F"};
var sortedStringArray = SomeArrayOfString.OrderBy(p => p.Length).ThenBy(p => p);
// foreach(var str in sortedStringArray)
// {
//     Console.WriteLine(str);
// }

//Third one 
int k = 5;
var A  = (from str in SomeArrayOfString
    where str.Length % 2 is not 0 
    where char.IsUpper(str[0]) 
    select str).Reverse();
// foreach(var si in A) Console.WriteLine(si);

//forth one
var SortedIntArray1= SomeArray.Distinct();
var SortedIntArray2 = 
    from numb in SortedIntArray1
    where numb > 0
    select numb;

foreach(var si in SortedIntArray2) Console.WriteLine(si);
