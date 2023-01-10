namespace DataAccessLayer.Connected;
using MySql.Data.MySqlClient;
using BusinessObjectLayer;

public static class DBManager{


    public static List<Department> GetAllDepartMent(){
           
           List<Department> allDept=new List<Department>();
        const string connstring=@"server=localhost;port=3306;user=root;password=root@123;database=transflower";

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=connstring;
        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText="Select * from departments";
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["id"].ToString());
                string name=reader["name"].ToString();
                string location=reader["Location"].ToString();
                Department dept=new Department{
                       Id=id,
                       Name=name,
                       Location=location

                };
                allDept.Add(dept);
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return allDept;
    }

    public static List<Employee> GetDeptDetails(int deptid){
        Console.WriteLine(deptid);
        List<Employee> allEmp=new List<Employee>();
        const string connstring=@"server=localhost;port=3306;user=root;password=root@123;database=transflower";

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=connstring;
        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText="Select * from employees where deptid="+deptid;
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["id"].ToString());
                string name=reader["firstname"].ToString();
                string lastname=reader["lastname"].ToString();
                string address=reader["address"].ToString();
                string email=reader["email"].ToString();
                int dpid=int.Parse(reader["deptid"].ToString());
                Employee emp=new Employee{
                    Id=id,
                    FirstName=name,
                    LastName=lastname,
                    Address=address,
                    Email=email,
                    DeptId=dpid
                };

                allEmp.Add(emp);
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return allEmp;

    }
}