import { NavLink } from "react-bootstrap";
import "./styles.css";
import AboutUs from "../AboutUs";
import CustomNav from "../CustomNav/CustomNav";
import { useEffect, useState } from "react";
import Title from "../Title/Title";

export default function Parallax() {
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
    <>
      <section className="banner container">
        <CustomNav display={display} dynamicStyles={display ? `visible` : ""} />
        <Title />
        <a href="#AboutUs" className="btn btn-primary">
          Drasti
        </a>
        <NavLink href="AboutUs">
          {/* <button className="btn btn-primary">Wellcome!</button> */}
        </NavLink>
      </section>
      <AboutUs />
    </>
  );
}
