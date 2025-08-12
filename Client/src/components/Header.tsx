import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Header() {
    return (
        <AppBar position="static" color="secondary">
            <Toolbar>
                <Typography variant="h6" >E-Commerce Store</Typography>
            </Toolbar>
        </AppBar>
    );
}