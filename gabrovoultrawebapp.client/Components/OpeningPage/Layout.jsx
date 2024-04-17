import "./styles.css";
import AboutUs from "../AboutUs";
import Distances from "../Distances/Distances/Distances";
import Header from "../Header/Header";
import { Gallery } from "../Gallery/Gallery";

export default function Layout() {
  return (
    <div id="Home" className="">
      <Header />
      <AboutUs />
      <Distances />
      <Gallery />
    </div>
  );
}
