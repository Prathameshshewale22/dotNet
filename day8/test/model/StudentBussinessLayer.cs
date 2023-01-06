namespace bussinesslayer;
using DataLayer;
using System.Collections.Generic;

public class StudnetBusinessLayer{
List<Student> students=new List<Student>();


public bool insertData(int sid,string name){
    students.Add(new Student(name,sid));
    return true;
}


}