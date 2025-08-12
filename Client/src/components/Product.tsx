import type { IProduct } from "../models/IProduct"

interface Props {
    product: IProduct
}

export default function Product({ product }: Props) {
    return (
        <div>
            <h3>{product.name}</h3>
            <p>Price: ${product.price}</p>
        </div>
    )
}