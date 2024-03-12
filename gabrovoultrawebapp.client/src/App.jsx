import "./App.css";
import Header from "../Components/Header";
import Navigation from "../Components/Navigation";
import { ImageAccordion } from "../Components/Accordeon";
import InfinityScroll from "../Components/InfinityScroll";
import Parallax from "../Components/OpeningPage/Parallax";
export default function App() {
  return (
    <>
      <Parallax />
      <Navigation />
      <ImageAccordion />
      <InfinityScroll />
    </>
  );
}
