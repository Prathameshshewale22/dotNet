import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { Product } from "./components/Product";
import { Addproduct } from "./components/Addproduct";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: 'products',
    element: <Product />
  },
  {
    path: 'Addproduct',
    element: <Addproduct />
  }
];

export default AppRoutes;