

using MathEngine;

// MathOprations opr=new MathOprations();

// Console.WriteLine(opr.Addition(45,42));
// Console.WriteLine(opr.Substraction(45,42));
// Console.WriteLine(opr.Multiple(45,42));
// Console.WriteLine("Result "+opr.Result);
// Console.WriteLine(opr.Divide(45,5));

int[] arr={42,45,68,25,36,74};

var arr1=arr.Take(3);
// arr.forEach((a)=>{Console.WriteLine(a);});
foreach(int a in arr1){
    Console.WriteLine(a);
}

 arr1=arr.Skip(3);
foreach(int a in arr1){
    Console.WriteLine(a);
}

string[] words = { "cherry", "apple", "blueberry","banana", "mango" };

var str=from word in words select *; 
