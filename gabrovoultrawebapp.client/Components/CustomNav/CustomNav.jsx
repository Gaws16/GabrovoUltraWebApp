import { Nav } from "react-bootstrap";
import styles from "./CustomNav.module.css";
// eslint-disable-next-line react/prop-types
function CustomNav({ display, dynamicStyles }) {
  if (!display) {
    return null;
  }
  return (
    <nav className={`sticky-top ${styles.nav} ${dynamicStyles}`}>
      <ul className="d-flex flex-col gap-5 text-light style-none">
        <li>
          <Nav.Link href="#AboutUs">Test</Nav.Link>
        </li>
        <li>
          <Nav.Link href="#AboutUs">Test</Nav.Link>
        </li>
        <li>
          <Nav.Link href="#AboutUs">Test</Nav.Link>
        </li>
        <li>
          <Nav.Link href="#AboutUs">Test</Nav.Link>
        </li>
        <li>
          <Nav.Link href="#AboutUs">Test</Nav.Link>
        </li>
      </ul>
    </nav>
  );
}

export default CustomNav;
