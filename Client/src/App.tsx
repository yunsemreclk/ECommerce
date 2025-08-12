import React, { useEffect, useState } from 'react';

function App() {
  return (
    <>
      <Header />
      <ProductList />
    </>

  )
}

function Header() {
  return (
    <h1>E-Commerce App</h1>
  )
}

function ProductList() {

  const [products, setProducts] = useState<any[]>([]);

  useEffect(() => {
    fetch('http://localhost:5037/api/products')
      .then(response => response.json())
      .then(data => { setProducts(data) })
  }, []);


  return (
    <div>
      <h2>Product List</h2>
      {products.map((product) => (
        <Product key={product.id} p={product} />
      ))}
    </div>
  )
}
function Product(props: any) {
  return (
    <div>
      <h3>{props.p.name}</h3>
      <p>Price: ${props.p.price}</p>
    </div>
  )
}

export default App
