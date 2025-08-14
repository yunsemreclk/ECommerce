import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material"
import { AddShoppingCart, Search } from "@mui/icons-material"
import type { IProduct } from "../../models/IProduct"
import { Link } from "react-router"

interface Props {
    product: IProduct
}

export default function Product({ product }: Props) {
    return (
        <Card >
            <CardMedia image={`http://localhost:5037/images/${product.imageUrl}`} title={product.name} style={{ height: 0, paddingTop: '56.25%' }} />
            <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                    {product.name}
                </Typography>
                <Typography variant="h6" color="grey">
                    ${product.price.toFixed(2)}
                </Typography>
            </CardContent>
            <CardActions>
                <Button variant="contained" color="info" size="small" startIcon={<AddShoppingCart />}>
                    Add to Cart
                </Button>
                <Button component={Link} to={`/catalog/${product.id}`} variant="outlined" color="primary" size="small" startIcon={< Search />}>
                    View
                </Button>
            </CardActions>

        </Card>
    )
}