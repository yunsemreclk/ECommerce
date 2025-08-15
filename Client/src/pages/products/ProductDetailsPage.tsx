import { CircularProgress, Divider, Grid, Table, TableBody, TableCell, TableContainer, TableRow, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useParams } from "react-router";
import type { IProduct } from "../../models/IProduct";
import requests from "../../api/request";
import NotFound from "../../errors/NotFound";

export default function ProductDetailsPage() {

    const { id } = useParams<{ id: string }>();
    const [product, setProduct] = useState<IProduct | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        id && requests.Catalog.getById(Number(id))
            .then(data => setProduct(data))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [id]);

    if (loading) return <CircularProgress />;

    if (!product) return <NotFound />;



    return (
        <Grid container spacing={4} >
            <Grid size={{ xs: 12, sm: 12, md: 6, lg: 4 }}>
                <img src={`http://localhost:5037/images/${product.imageUrl}`} alt={product.name} style={{ width: '100%' }} />
            </Grid>
            <Grid size={{ xs: 12, sm: 12, md: 6, lg: 8 }}>
                <Typography variant="h3">{product.name}</Typography>
                <Divider sx={{ my: 3 }} />
                <Typography variant="h5" color="green">${product.price.toFixed(2)}</Typography>
                <TableContainer>
                    <Table>
                        <TableBody>
                            <TableRow>
                                <TableCell>Name</TableCell>
                                <TableCell>{product.name}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Description</TableCell>
                                <TableCell>{product.description}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Stock</TableCell>
                                <TableCell>{product.stock}</TableCell>
                            </TableRow>
                        </TableBody>
                    </Table>
                </TableContainer>
            </Grid>
        </Grid>
    )
}