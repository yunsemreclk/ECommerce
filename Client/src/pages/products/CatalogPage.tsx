import { useState, useEffect } from "react";
import type { IProduct } from "../../models/IProduct";
import ProductList from "./ProductList";
import requests from "../../api/request";

export default function CatalogPage() {
    const [products, setProducts] = useState<IProduct[]>([]);

    useEffect(() => {
        requests.Catalog.getAll()
            .then(data => setProducts(data))
    }, []);
    return (
        <ProductList products={products} />
    )
}