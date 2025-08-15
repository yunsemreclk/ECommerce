import { Container, Divider, Typography } from "@mui/material";
import { useLocation } from "react-router";

export default function ServerError() {

    const { state } = useLocation();

    return (
        <Container>
            {
                state?.error ? (
                    <>
                        <Typography variant="h5" color="error">{state.error.title} - {state.status}</Typography>
                        <Divider />
                        <Typography variant="body2" >{state.error.detail} || "Unknown Error"</Typography>
                    </>
                ) : (
                    <Typography variant="h4" sx={{ textAlign: 'center', marginTop: '50px' }}>500 - Server Error</Typography>
                )
            }
        </Container>
    );
}