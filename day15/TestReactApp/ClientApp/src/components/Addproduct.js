import { useState } from "react"
import { useNavigate } from "react-router-dom";
import Services from "./Services";


export var Addproduct=()=>{
    let [prodob ,setprod]=useState({pid:"",pname:"",description:"",price:"",quntity:""});

    const handlechange=(event)=>{
    let {name,value}=event.target
    setprod({...prodob,[name]:value});
    
    }
    var navigator=useNavigate();
    const senddata=(prodob)=>{
        console.log(prodob);
        Services.Addproduct(prodob).then((resp)=>{console.log(resp.data)}).catch(()=>{});
         navigator("/products");
    }

    return(
        <div>
            <form>
  <div class="form-group">
    <label for="pid">Product Id</label>
    <input type="number" class="form-control" id="pid" aria-describedby="emailHelp" 
    name="pid" placeholder="Enter pid" value={prodob.pid} onChange={handlechange}/>

  </div>
  <div class="form-group">
    <label for="pname">Product Name</label>
    <input type="text" class="form-control" id="pname" name="pname" placeholder="pname" 
    value={prodob.pname} onChange={handlechange}/>
  </div>
  <div class="form-group">
    <label for="description">Description</label>
    <input type="text" class="form-control" id="description" name="description" placeholder="description" value={prodob.description} onChange={handlechange}/>
  </div>
  <div class="form-group">
    <label for="price">Price</label>
    <input type="number" class="form-control" id="price" name="price" placeholder="price" value={prodob.price} onChange={handlechange}/>
  </div>
  <div class="form-group">
    <label for="quntity">Quntity</label>
    <input type="number" class="form-control" id="quntity" name="quntity" placeholder="quntity"  value={prodob.quntity} onChange={handlechange}/>
  </div>
  <button type="button" class="btn btn-primary" onClick={senddata}>Submit</button>
</form>
        </div>
    )
}

// export default Addproduct;