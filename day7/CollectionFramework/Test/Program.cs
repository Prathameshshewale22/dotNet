
using Institute;


Student s1=new Student(1,"prathamesh","pune");
Student s2=new Student(2,"akash","pune");
Student s3=new Student(3,"akshay","shirdi");
Student s4=new Student(4,"sourav","beed");

bool flag=false;

while(!flag){
    Console.WriteLine("enter the choice");
    Console.WriteLine("1.List/2.stack/3.Queue/4.Dictionary/5.exit");

    switch(Convert.ToInt32(Console.ReadLine())){
    
    case 1:
    //create List
    List<Student> Students=new List<Student>();
    bool flag1=false;
    while(!flag1){
        Console.WriteLine("enter choice");
        Console.WriteLine("1.add obj/2.remove/3.sort/4.display/5.exit");
        switch(Int32.Parse(Console.ReadLine())){
           case 1:
           //adding studnets in list
           Students.Add(s1);
           Students.Add(s4);
           Students.Add(s2);
           Students.Add(s3);
           break;

           case 2:
          //Remove Studnet from list
          Console.WriteLine("enter the sid");
          int sid=Int32.Parse(Console.ReadLine());
          foreach(Student s in Students){
            if(s.Sid==sid){
                Students.Remove(s);
                break;
            }
          }
          Console.WriteLine("Studnet removed!!");
           break;

           case 3:
           //sort
           Students.Sort();
          foreach(Student s in Students){
            Console.WriteLine(s);
          }

           break;

           case 4:
             //display
             foreach(Student s in Students){
                Console.WriteLine(s);
             }
           break;
           case 5:
           flag1=true;
           break;
        }
    }
    
    break;

    case 2:
    //using stack
    Stack<Student> StackofStudent=new Stack<Student>();
    bool flag2=false;
    while(!flag2){
        Console.WriteLine("enter choice");
        Console.WriteLine("1.add obj/2.remove fro top/3.display/4.exit");
        switch(Int32.Parse(Console.ReadLine())){
            case 1:
            //add in stack
            StackofStudent.Push(s1);
            StackofStudent.Push(s2);
            StackofStudent.Push(s3);
            StackofStudent.Push(s4);
            break;
            case 2:
            //remove form top
            Console.WriteLine(StackofStudent.Pop());
            break;
            case 3:
            //display
            Student[] arr=StackofStudent.ToArray();
            for(int i=0;i<arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
            break;
            case 4:
              flag2=true;
            break;
        }
    }
    break;

    case 3:
    //using Queue
    Queue<Student> StudnetQueue=new Queue<Student>();
    bool flag3=false;
    while(!flag3){
        Console.WriteLine("enter choice");
        Console.WriteLine("1.add obj/2.remove fro top/3.display/4.exit");
    switch(Int32.Parse(Console.ReadLine())){
        case 1:
         //add in queue
         StudnetQueue.Enqueue(s1);
         StudnetQueue.Enqueue(s2);
         StudnetQueue.Enqueue(s3);
         StudnetQueue.Enqueue(s4);
        break;
       case 2: 
       //dequeue 
       Console.WriteLine(StudnetQueue.Dequeue());
       break;
       case 3:
       //display
       Student [] st=StudnetQueue.ToArray();
       for(int i=0;i<st.Length; i++){
                Console.WriteLine(st[i]);
            }
       break;
       case 4:
       //exit
       flag3=true;

       break;

    }

    }
    break;

    case 4:
    // using Dictionary
   Dictionary<int,Student> Studs=new Dictionary<int,Student>();
bool flag4=false;
    while(!flag4){
        Console.WriteLine("enter choice");
        Console.WriteLine("1.add obj/2.remove /3.display/4.exit");
        switch(Int32.Parse(Console.ReadLine())){
            case 1:
            //add in dictionary
            Studs.Add(s3.Sid,s3);
            Studs.Add(s1.Sid,s1);
            Studs.Add(s4.Sid,s4);
            Studs.Add(s2.Sid,s2);
            
            
            break;
            case 2:
            //remove obj
            Console.WriteLine("enter the sid");
            int sid=Int32.Parse(Console.ReadLine());
              Studs.Remove(sid);
              Console.WriteLine("Object removed!!");
            break;
            case 3:
             //display
             foreach(Student st in Studs.Values){
                 Console.WriteLine(st);
             }
            break;
            case 4:
            //sort 
            SortedDictionary<int,Student> sortedDictionary=new SortedDictionary<int, Student>(Studs);
            foreach(Student st in Studs.Values){
                 Console.WriteLine(st);
             }
            break;
            case 5:
            //exit
            flag4=true;
            break;
        }
    }
    break;

    case 5:
        flag=true;
    break;
    }


}
