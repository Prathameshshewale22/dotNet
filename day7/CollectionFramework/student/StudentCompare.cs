namespace CompareStudent;

using Institute;

public class StudnetCompare:IComparer<Student>{

    public int Compare(Student s1,Student s2){
        if(s1.Sid > s2.Sid){
            return 1;
        }
        if(s1.Sid < s2.Sid){
            return -1;
        }
        else
        return 0;
    }
}