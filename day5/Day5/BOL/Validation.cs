namespace BOL;

public static class Validate{


    public static Student GetById(int id,List<Student> stud){
        foreach(Student st in stud){
            if(st.Sid==id){
                return st;
            }
        }
        return null;
    }

    public static bool deleteReacord(int id,List<Student> stud){
        foreach(Student st in stud){
            if(st.Sid==id){
                stud.Remove(st);
                return true;
            }
        }
        return false;

    }
}