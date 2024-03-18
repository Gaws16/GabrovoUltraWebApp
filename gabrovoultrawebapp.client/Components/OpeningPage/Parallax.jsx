import { Button, NavLink } from "react-bootstrap";
import "./styles.css";

export default function Parallax() {
  return (
    <>
      <section className="banner container">
        <h2>Gabrovo Ultra</h2>
        <NavLink href="gallery">
          <button className="btn btn-primary">Wellcome!</button>
        </NavLink>
      </section>
    </>
  );
}
