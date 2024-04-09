import Axios from "axios";

export const axios = Axios.create({
  baseURL: "https://localhost:7263/api",
});
