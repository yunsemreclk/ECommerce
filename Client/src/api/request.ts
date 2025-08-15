import axios, { AxiosError, type AxiosResponse } from 'axios';

axios.defaults.baseURL = 'http://localhost:5037/api/';

axios.interceptors.response.use(response => {
    return response;
}, (error: AxiosError) => {
    console.log("interceptor error...", error);
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