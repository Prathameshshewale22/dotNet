namespace DataAccessLayer.Connected;
using MySql.Data.MySqlClient;
using BusinessObjectLayer;

public static class DBManagerForSql{


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
        // Console.WriteLine(deptid);
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

    public static List<Product> AllProduct(){
        List<Product> NewProducts=new List<Product>();
        bool status=false;
    const string connstring=@"server=localhost;port=3306;user=root;password=root@123;database=test";
    MySqlConnection con=new MySqlConnection();
    con.ConnectionString=connstring;
   try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText="Select * from product";
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int pid=int.Parse(reader["pid"].ToString());
                string pname=reader["pname"].ToString();
                string description=reader["description"].ToString();
                int price=int.Parse(reader["price"].ToString());
                int qty=int.Parse(reader["quntity"].ToString());
                Product prod=new Product{
                    Pid=pid,
                    Pname=pname,
                    Description=description,
                    Price=price,
                    Quntity=qty
                };

                NewProducts.Add(prod);
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return NewProducts;

    }
     public static bool InsertProduct(List<Product> NewProducts){
        bool status=false;
    const string connstring=@"server=localhost;port=3306;user=root;password=root@123;database=test";
    MySqlConnection con=new MySqlConnection();
    con.ConnectionString=connstring;
    try{
        con.Open();
        // MySqlCommand cmd=new MySqlCommand();
        // cmd.Connection=con;
        foreach(Product p in NewProducts){
        string query="insert into Product Values( '" + p.Pid + "','"
            + p.Pname + "','" + p.Description + "','" + p.Price + "',  '" +p.Quntity +"')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            
            cmd.ExecuteNonQuery();

            status = true;
        }

    }
    catch(Exception e){
          Console.WriteLine(e);
    }
    finally{
        con.Close();
    }
        return status;

    }
    public static Product GetProdDetails(int pid){
        // Console.WriteLine(deptid);
        // List<Product> allEmp=new List<Product>();
        Product product=null;
        const string connstring=@"server=localhost;port=3306;user=root;password=root@123;database=test";

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=connstring;
        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText="Select * from product where pid="+pid;
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
               int id=int.Parse(reader["pid"].ToString());
                string pname=reader["pname"].ToString();
                string description=reader["description"].ToString();
                int price=int.Parse(reader["price"].ToString());
                int qty=int.Parse(reader["quntity"].ToString());
                Product prod=new Product{
                    Pid=id,
                    Pname=pname,
                    Description=description,
                    Price=price,
                    Quntity=qty
                };
            product=prod;
                
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
         return product;

    }
}