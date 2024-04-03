import "./App.css";
import { Gallery } from "../Components/Gallery/Gallery";
import InfinityScroll from "../Components/InfinityScroll";
import Intro from "../Components/OpeningPage/Intro";
import { BrowserRouter } from "react-router-dom";
import { Routes, Route } from "react-router";
import Register from "../Components/Register/Register";
import AllRunners from "../Components/AllRunners";

import Login from "../Components/Login/Login";
export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route index element={<Intro />} />
        <Route path="/gallery" element={<Gallery />} />
        <Route path="/results" element={<InfinityScroll />} />
        <Route path="/register" element={<Register />} />
        <Route path="/login" element={<Login />} />
        <Route path="/runners" element={<AllRunners />} />
      </Routes>
    </BrowserRouter>
  );
}
