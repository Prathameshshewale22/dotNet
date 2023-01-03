namespace person;

public partial class Product{

    private string[] str=new string[3];

    public Product(){
        this.str[0]="abc";
        this.str[1]="xyz";
        this.str[2]="asd";
    }

    public string this[int index]{
        get{return str[index];}
        set{this.str[index]=value;}
    }
   


}