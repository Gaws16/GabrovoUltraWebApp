import { NavLink } from "react-bootstrap";
import styles from "./CustomNav.module.css";
// eslint-disable-next-line react/prop-types
function CustomNav({ display, dynamicStyles }) {
  if (!display) {
    return null;
  }
  return (
    <nav
      className={`sticky-top ${styles.nav} ${dynamicStyles} d-flex justify-content-between  p-3`}
    >
      <ul className="d-flex gap-5 text-light style-none">
        <li>
          <NavLink href="#AboutUs">Test</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Test</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Test</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Test</NavLink>
        </li>
        <li>
          <NavLink href="#AboutUs">Test</NavLink>
        </li>
      </ul>
      <ul className="d-flex flex-col gap-5 text-light">
        <li>
          <NavLink href="Login">Login</NavLink>
        </li>
        <li>
          <NavLink href="Register">Register</NavLink>
        </li>
      </ul>
    </nav>
  );
}

export default CustomNav;
