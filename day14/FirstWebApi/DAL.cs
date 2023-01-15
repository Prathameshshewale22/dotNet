namespace DataAccessLayer;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using BOL;
public class DAL{


    public static string connstring=@"server=localhost;port=3306;user=root; password=root@123;database=test";
    public static List<Product> GetAllProducts(){

        List<Product> allProduct=new List<Product>();
        
          MySqlConnection conn=new MySqlConnection();
          conn.ConnectionString=connstring;
          try{
            DataSet ds=new DataSet();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=conn;
            string str="select * from product";
            cmd.CommandText=str;

            MySqlDataAdapter da=new MySqlDataAdapter();
            da.SelectCommand=cmd;
            da.Fill(ds);
            DataTable dt=ds.Tables[0];
            DataRowCollection dr=dt.Rows;
            foreach(DataRow d in dr){
                int pid=Int32.Parse(d["pid"].ToString());
                string pname=d["pname"].ToString();
                string description=d["description"].ToString();
                int price=Int32.Parse(d["price"].ToString());
                int quntity=Int32.Parse(d["quntity"].ToString());
                Product prod=new Product(pid,pname,description,price,quntity);
                allProduct.Add(prod);
            }
          }
          catch(Exception e){
            Console.WriteLine(e);
          }
          return allProduct;
    }

    public static Product GetById(int id){
           Product prod=null;
           MySqlConnection conn=new MySqlConnection();
           conn.ConnectionString=connstring;
           try{
                DataSet ds=new DataSet();
                MySqlCommand cmd=new MySqlCommand();
                cmd.Connection=conn;
                cmd.CommandText="select * from product where pid="+id;
                MySqlDataAdapter ad=new MySqlDataAdapter();
                ad.SelectCommand=cmd;
                ad.Fill(ds);

                DataTable dt=ds.Tables[0];
                DataRowCollection rows=dt.Rows;
                foreach(DataRow d in rows){
                      int pid=Int32.Parse(d["pid"].ToString());
                string pname=d["pname"].ToString();
                string description=d["description"].ToString();
                int price=Int32.Parse(d["price"].ToString());
                int quntity=Int32.Parse(d["quntity"].ToString());
                Product product=new Product(pid,pname,description,price,quntity);
                prod=product;
                }

           }
           catch(Exception e){
            Console.WriteLine(e);
           }
           return prod;
    }

}