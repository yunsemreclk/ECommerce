import axios, { AxiosError, type AxiosResponse } from 'axios';
import { toast } from 'react-toastify';
import { router } from '../router/Routes';


axios.defaults.baseURL = 'http://localhost:5037/api/';

axios.interceptors.response.use(response => {
    return response;
}, (error: AxiosError) => {
    const { data, status } = error.response as AxiosResponse;
    switch (status) {
        case 400:
            toast.error(data.title);
            break;
        case 401:
            toast.error(data.title);
            break;
        case 404:
            toast.error("/not-found");
            break;
        case 500:
            router.navigate('/server-error', { state: { error: data, status: status } });
            break;
        default:
            toast.error('Something went wrong');
            break;
    }

    return Promise.reject(error.response);
});

axios.interceptors.request.use(request => {
    console.log("interceptor request...", request);
    return request;
}, (error: AxiosError) => {
    console.log("interceptor error...", error);
    return Promise.reject(error);
});


const request = {
    get: (url: string) => axios.get(url).then((response: AxiosResponse) => response.data),
    post: (url: string, body: {}) => axios.post(url, body).then((response: AxiosResponse) => response.data),
    put: (url: string, body: {}) => axios.put(url, body).then((response: AxiosResponse) => response.data),
    delete: (url: string) => axios.delete(url).then((response: AxiosResponse) => response.data)
}

const Catalog = {
    getAll: () => request.get('products'),
    getById: (id: number) => request.get(`products/${id}`)
}

const requests = {
    Catalog
}

export default requests;