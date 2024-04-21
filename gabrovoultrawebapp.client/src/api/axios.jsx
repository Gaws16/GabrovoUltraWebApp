import Axios from "axios";

const BASE_URL = "https://localhost:7263/api";

export const axios = Axios.create({
  baseURL: BASE_URL,
});
export const axiosPrivate = Axios.create({
  baseURL: BASE_URL,
  headers: {
    "Content-Type": "application/json",
  },
  withCredentials: true,
});
