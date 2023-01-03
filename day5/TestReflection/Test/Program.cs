
using System.Reflection;
String path=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day5\TestReflection\product\bin\Debug\net7.0/Product.dll";

Assembly asm=Assembly.LoadFile(path);

Console.WriteLine(asm.GetName());

// Type t=asm.CreateInstance();

Type[] types=asm.GetTypes();

for(int i=0;i<types.Count();i++){
    Console.WriteLine(types[i].Name);
    ConstructorInfo[] cinfo=types[i].GetConstructors();
    foreach(ConstructorInfo c in cinfo){
        Console.WriteLine(c);
    }
}









