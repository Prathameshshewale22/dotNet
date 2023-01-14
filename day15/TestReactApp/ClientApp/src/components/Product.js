import React, { Component } from 'react';

export class Product extends Component {
  static displayName = Product.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
  }

  componentDidMount() {
    this.populateProductData();
  }

  static renderProductsTable(products) {
    return (
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
              <td>{product.pname}</td>
              <td>{product.description}</td>
              <td>{product.price}</td>
              <td>{product.quntity}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tableLabel">Products List</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateProductData() {
    const response = await fetch('products');
    const data = await response.json();
    this.setState({ products: data, loading: false });
  }
}
