import axios from 'axios';

 class Services{

    constructor(){
        this.baseurl="http://localhost:7008/Products";
    }

    getallproduct(){
        return axios.get(this.baseurl);
    }

    Addproduct(ob){
        console.log(ob);
        return axios.post(this.baseurl,ob);
    }
    
    delete(pid){
        console.log(pid);
        return axios.delete(this.baseurl+"/"+pid);
    }
}

export default new Services();