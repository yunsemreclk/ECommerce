import { useEffect, useState } from 'react';
import type { IProduct } from '../models/IProduct';
import Header from './Header';
import { Container, CssBaseline } from '@mui/material';
import { Outlet } from 'react-router';

function App() {
  const [products, setProducts] = useState<IProduct[]>([]);

  useEffect(() => {
    fetch('http://localhost:5037/api/products')
      .then(response => response.json())
      .then(data => { setProducts(data) })
  }, []);

  return (
    <>
      <CssBaseline />
      <Header />
      <Container>
        <Outlet />
      </Container>
    </>

  )
}

export default App
