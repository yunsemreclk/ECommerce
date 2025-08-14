import { Grid } from "@mui/material";
import type { IProduct } from "../../models/IProduct";
import Product from "./Product";


interface Props {
    products: IProduct[];
}

export default function ProductList({ products }: Props) {
    return (

        <Grid container spacing={2}>

            {products.map((product: IProduct) => (
                <Grid size={{ xs: 12, sm: 6, md: 4, lg: 3 }} key={product.id}>
                    <Product product={product} />
                </Grid>
            ))}
        </Grid>
    )
}