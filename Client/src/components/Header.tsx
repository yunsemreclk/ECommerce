
import { ShoppingCart } from "@mui/icons-material";
import { AppBar, Badge, Box, Button, IconButton, Stack, Toolbar, Typography } from "@mui/material";
import { NavLink } from "react-router";

const links = [
    { title: 'Home', to: '/' },
    { title: 'Products', to: '/catalog' },
    { title: 'About', to: '/about' },
    { title: 'Contact', to: '/contact' }
];

const navStyle = {
    textDecoration: 'none',
    color: 'inherit',
    "&.active": {
        color: 'black',
        textDecoration: 'underline',
    }
};

export default function Header() {
    return (
        <><AppBar position="static" color="secondary">
            <Toolbar sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <Box sx={{ display: 'flex', alignItems: 'center', gap: 2 }}>
                    <Typography variant="h6">E-Commerce Store</Typography>
                    <Stack direction="row" spacing={2} sx={{ display: { xs: 'none', sm: 'flex' } }}>
                        {links.map(link => (
                            <Button component={NavLink} to={link.to} sx={navStyle} >
                                {link.title}
                            </Button>
                        ))}
                    </Stack>
                </Box>
                <Box>
                    <IconButton size="large" edge="end" color="inherit" aria-label="cart">
                        <Badge badgeContent={4} color="error">
                            <ShoppingCart />
                        </Badge>
                    </IconButton>
                </Box>
            </Toolbar>
        </AppBar > <br /></>
    );
}