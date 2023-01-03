using person;

// Person p1=Person.createInstance();
// // Person p2=new Person(2,"xyz");

// p1.Display(1,2,3,4,5);
// // p1.Id=2;
// // p1.Display();
// // p2.Display();
// int n1=10;
// int n2=20;
// p1.Swapping(ref n1,ref n2);

// double area;
// double cir;
// p1.Calculate(10,out area, out cir);
// Console.WriteLine(area+" "+cir);


//int []arr={1,2,3,4,5,6,7};
// int[] arr=new int[5];
// for(int i=0,j=0;i<arr.Length;i++,j++){
//     arr[i]=j;
// }
// foreach(int a in arr){
//     Console.Write(a+" ");
// }

// Person[] p1={
//     new Person{Id=4,FirstName="abc"},
//     new Person{Id=5,FirstName="xyx"}
// };


// Console.WriteLine(p1.GetHashCode());

// int [,] arr={
//     {11,20},
//     {30,40}
// };
// int res=arr[1 , 0];
// Console.WriteLine(res);
// // Console.WriteLine(arr[1][1]);

// int [][]arr1=new int[2][];
// arr1[0]=new int [5]{1,2,3,4,5};
// arr1[1]=new int [3]{6,7,8};

// Console.WriteLine(arr1[0][1]);

// Product p1=new Product();
// p1.display();

// Console.WriteLine(p1[2]);

// Person p1=new Student();
// p1.display();

Student s=new Student(20);
Console.WriteLine(s.GetHashCode());

Student s1=(Student)s.Clone();
Console.WriteLine(s1.GetHashCode());