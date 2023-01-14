namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DataAccessLayer;

public class HRManger{


    public List<Department> GetallDept(){

        List<Department> depts=DataAccessLayer.Connected.DBManagerForSql.GetAllDepartMent();
        return depts;
    }

    public List<Employee> allEmpDetails(int Deptid){
        Console.WriteLine(Deptid);
        List<Employee> emps=DataAccessLayer.Connected.DBManagerForSql.GetDeptDetails(Deptid);
        return emps;
    }
}