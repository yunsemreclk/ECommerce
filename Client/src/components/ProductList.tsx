import type { IProduct } from "../models/IProduct";
import Product from "./Product";

interface Props {
    products: IProduct[];
}

export default function ProductList({ products }: Props) {
    return (
        <div>
            <h2>Product List</h2>
            {products.map((product: any) => (
                <Product key={product.id} product={product} />
            ))}
        </div>
    )
}