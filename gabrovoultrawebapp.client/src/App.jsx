import "./App.css";
import Header from "../Components/Header";
import Navigation from "../Components/Navigation";
import { ImageAccordion } from "../Components/Accordeon";
import InfinityScroll from "../Components/InfinityScroll";
export default function App() {
  return (
    <>
      <Navigation />
      <ImageAccordion />
      <InfinityScroll />
    </>
  );
}
