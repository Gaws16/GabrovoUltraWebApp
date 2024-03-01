import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App.jsx";
import Header from "../Components/Header.jsx";
import "./index.css";
import Register from "../Components/Register.jsx";
import "bootstrap/dist/css/bootstrap.min.css";

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <Header />
  </React.StrictMode>
);
