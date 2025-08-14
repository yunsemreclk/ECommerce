import { Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useParams } from "react-router";
import type { IProduct } from "../../models/IProduct";

export default function ProductDetailsPage() {

    const { id } = useParams();
    const [product, setProduct] = useState<IProduct | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        fetch(`http://localhost:5037/api/products/${id}`)
            .then(response => response.json())
            .then(data => setProduct(data))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [id]);

    if (loading) return <Typography variant="h4">Loading...</Typography>;

    if (!product) return <Typography variant="h4">Product not found</Typography>;



    return (
        <div>
            <Typography variant="h4">{product.name}</Typography> {/* Example: Display product name */}
            <Typography variant="h6">{product.description}</Typography> {/* Example: Display product description */}
            <Typography variant="body1">Price: ${product.price}</Typography> {/* Example: Display product price */}
        </div>
    )
}