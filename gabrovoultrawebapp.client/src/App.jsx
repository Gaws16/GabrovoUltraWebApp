import "./App.css";
import { ImageAccordion } from "../Components/Accordeon";
import InfinityScroll from "../Components/InfinityScroll";
import Parallax from "../Components/OpeningPage/Parallax";
import { BrowserRouter } from "react-router-dom";
import { Routes, Route } from "react-router";

export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route index element={<Parallax />} />
        <Route path="/gallery" element={<ImageAccordion />} />
        <Route path="/results" element={<InfinityScroll />} />
      </Routes>
    </BrowserRouter>
  );
}
