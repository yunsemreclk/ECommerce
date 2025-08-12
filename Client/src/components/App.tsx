import { useEffect, useState } from 'react';
import type { IProduct } from '../models/IProduct';
import Header from './Header';
import ProductList from './ProductList';

function App() {
  const [products, setProducts] = useState<IProduct[]>([]);

  useEffect(() => {
    fetch('http://localhost:5037/api/products')
      .then(response => response.json())
      .then(data => { setProducts(data) })
  }, []);

  return (
    <>
      <Header />
      <ProductList products={products} />
    </>

  )
}

export default App
