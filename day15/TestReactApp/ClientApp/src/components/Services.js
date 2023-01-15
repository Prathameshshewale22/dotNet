import axios from 'axios';

 class Services{

    constructor(){
        this.baseurl="https://localhost:7008/products";
    }

    getallproduct(){
        return axios.get(this.baseurl);
    }
}

export default new Services();