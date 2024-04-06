import { NavLink, Navbar, Image } from "react-bootstrap";
import styles from "./CustomNav.module.css";
import { Link } from "react-router-dom";

// eslint-disable-next-line react/prop-types
function CustomNav({ display, dynamicStyles }) {
  if (!display) {
    return null;
  }
  return (
    <Navbar
      className={`sticky-top ${styles.nav} ${dynamicStyles} d-flex justify-content-between p-3 bg-dark`}
    >
      <Navbar.Brand href="#home">
        <Image src="/src/assets/logo.png" width={70} height={50} />
      </Navbar.Brand>
      <ul className="d-flex gap-5 text-light list-unstyled">
        <li>
          <NavLink href="#Home">Начало</NavLink>
        </li>
        <li>
          <NavLink href="#Distances">Дистанции</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Участници</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Резултати</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Контакти</NavLink>
        </li>
      </ul>
      <ul className="d-flex flex-col gap-5 text-light list-unstyled">
        <li>
          <Link className="text-decoration-none text-light" to="/Login">
            Login
          </Link>
        </li>
        <li>
          <Link className="text-decoration-none text-light" to="/Register">
            Register
          </Link>
        </li>
      </ul>
    </Navbar>
  );
}

export default CustomNav;
