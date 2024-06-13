import Axios from "axios";

const BASE_URL = "https://app-gabrovoultra-gwc-dev-001.azurewebsites.net/api";

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
