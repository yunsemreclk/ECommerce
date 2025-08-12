import { AppBar, Container, Toolbar, Typography } from "@mui/material";

export default function Header() {
    return (
        <><AppBar position="static" color="secondary">
            <Toolbar>
                <Container>
                    <Typography variant="h6">E-Commerce Store</Typography>
                </Container>
            </Toolbar>
        </AppBar><br /></>
    );
}