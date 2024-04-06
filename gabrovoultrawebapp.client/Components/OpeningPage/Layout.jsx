import "./styles.css";
import AboutUs from "../AboutUs";
import CustomNav from "../CustomNav/CustomNav";
import { useEffect, useState } from "react";
import Title from "../Title/Title";
import DistancesHeader from "../Distances/Header/DistancesHeader";
import DustanceMain from "../Distances/Main/DistanceMain";
import { Container } from "react-bootstrap";

export default function Layout() {
  const [display, setDisplay] = useState(false);
  useEffect(() => {
    window.addEventListener("scroll", () => {
      if (window.scrollY > 400) {
        setDisplay(true);
      } else {
        setDisplay(false);
      }
    });
  }, []);
  return (
    <div id="Home">
      <CustomNav display={display} dynamicStyles={display ? `visible` : ""} />
      <Container fluid className="banner container">
        <Title />
      </Container>
      <AboutUs />
      <DistancesHeader id="Distances" />
      <DustanceMain />
    </div>
  );
}
