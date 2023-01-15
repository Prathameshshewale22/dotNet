import React, { Component, useEffect, useState } from 'react';
import Services from './Services';
import {Link} from 'react-router-dom';

export  const Product=()=>{
  let[prods,setprods]=useState([]);

  useEffect(()=>{
    Services.getallproduct().then((resp)=>{
      console.log(resp.data);
      setprods(resp.data);
    }).catch((err)=>{console.log(err)});
  },[])

   const deleteData=(pid)=>{
    console.log("in delete")
          Services.delete(pid).then((resp)=>{console.log(resp.data)}).catch(()=>{});
  }

  const renderlist=()=> {
    return prods.map((product) =>{
            return <tr key={product.pid}>
              <td>{product.pid}</td>
              <td>{product.pname}</td>
              <td>{product.description}</td>
              <td>{product.price}</td>
              <td>{product.quntity}</td>
              <td><button type="button" name="btn1" id="btn1" class="btn btn-danger" onClick={()=>deleteData(product.pid)}>delete</button></td>
            </tr>
            }
            )}
  

  // render=()=>{
  //   // let contents = this.state.loading
  //   //   ? <p><em>Loading...</em></p>
  //   //   : Product.renderProductsTable(this.state.products);
  // }

    return (
      <div>
        <h1 id="tableLabel">Products List</h1>
        <p>This component demonstrates fetching data from the server.</p>
        <Link to="/Addproduct">
      <button type="button" name="btn" id="btn">addproduct</button>
      </Link>
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Pid</th>
            <th>Pname</th>
            <th>Description</th>
            <th>Price</th>
            <th>Quntity</th>
          </tr>
        </thead>
        <tbody>
         {renderlist()}
        </tbody>
       </table>
      </div>
    )}