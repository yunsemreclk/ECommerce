import { useState, useEffect } from "react";
import type { IProduct } from "../../models/IProduct";
import ProductList from "./ProductList";

export default function CatalogPage() {
    const [products, setProducts] = useState<IProduct[]>([]);

    useEffect(() => {
        fetch('http://localhost:5037/api/products')
            .then(response => response.json())
            .then(data => { setProducts(data) })
    }, []);
    return (
        <ProductList products={products} />
    )
}