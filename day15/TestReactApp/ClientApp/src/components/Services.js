import axios from 'axios';

 class Services{

    constructor(){
        this.baseurl="http://localhost:7008/products";
    }

    getallproduct(){
        return axios.get(this.baseurl);
    }

    Addproduct(ob){
        console.log(ob);
        return axios.post(this.baseurl,ob);
    }
}

export default new Services();