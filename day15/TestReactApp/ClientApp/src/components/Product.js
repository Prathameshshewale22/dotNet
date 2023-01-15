import React, { Component } from 'react';
import Services from './Services';
import {Link} from 'react-router-dom';

export class Product extends Component {
  static displayName = Product.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
    this.deleteData = this.deleteData.bind(this);
  }

  componentDidMount() {
    this.populateProductData();
  }

  //   deleteData=(pid)=>{
  //   console.log("in delete")
  //         Services.delete(pid).then((resp)=>{console.log(resp.data)}).catch(()=>{});
  // }

  static renderProductsTable(products) {
    return (
      <div>
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
          {products.map(product =>
            <tr key={product.pid}>
              <td>{product.pid}</td>
              <td>{product.pname}</td>
              <td>{product.description}</td>
              <td>{product.price}</td>
              <td>{product.quntity}</td>
              <td><button type="button" name="btn1" id="btn1" class="btn btn-danger" onClick={()=>this.deleteData(product.pid)}>delete</button></td>
            </tr>
          )}
        </tbody>
      </table>
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Product.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tableLabel">Products List</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateProductData() {
    Services.getallproduct().then((resp)=>{
      console.log(resp.data);
      this.setState({products:resp.data , loading:false})
    }).catch(()=>{})
  }
}
