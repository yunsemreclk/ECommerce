import axios, { type AxiosResponse } from 'axios';

axios.defaults.baseURL = 'http://localhost:5037/api/';

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