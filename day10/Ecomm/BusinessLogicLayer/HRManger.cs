namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DataAccessLayer.Connected;

public class HRManger{


    public List<Department> GetallDept(){

        List<Department> depts=DBManager.GetAllDepartMent();
        return depts;
    }

    public List<Employee> allEmpDetails(int Deptid){
        Console.WriteLine(Deptid);
        List<Employee> emps=DBManager.GetDeptDetails(Deptid);
        return emps;
    }
}