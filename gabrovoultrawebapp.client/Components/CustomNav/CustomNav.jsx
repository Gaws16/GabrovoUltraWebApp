import { NavLink, Navbar, Image, Container, Nav } from "react-bootstrap";
import styles from "./CustomNav.module.css";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

// eslint-disable-next-line react/prop-types
function CustomNav({ loggedIn, display, dynamicStyles }) {
  const navigate = useNavigate();
  if (!display) {
    return null;
  }
  const handleLogout = () => {
    localStorage.clear();
    navigate("/");
  };
  return (
    <Navbar
      collapseOnSelect
      expand="lg"
      className={`sticky-top ${styles.nav} ${dynamicStyles} d-flex justify-content-between p-3 bg-dark text-light`}
    >
      <Container fluid>
        <Navbar.Brand href="#home">
          <Image src="/src/assets/logo.svg" width={60} height={60} />
        </Navbar.Brand>
        <Navbar.Toggle
          style={{ backgroundColor: "white" }}
          aria-controls="navbarScroll"
        />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav
            className="me-auto my-2 my-lg-0 text-light"
            style={{ maxHeight: "100px" }}
            navbarScroll
          >
            <NavLink style={{ color: "white" }} href="#Home">
              Начало
            </NavLink>

            <NavLink style={{ color: "white" }} href="#Distances">
              Дистанции
            </NavLink>

            <NavLink style={{ color: "white" }} href="#AboutUs">
              Участници
            </NavLink>

            <NavLink style={{ color: "white" }} href="#AboutUs">
              Резултати
            </NavLink>

            <NavLink style={{ color: "white" }} href="#AboutUs">
              Контакти
            </NavLink>
          </Nav>

          <ul className="d-flex flex-col gap-5 text-light list-unstyled">
            {localStorage.getItem("token") && loggedIn ? (
              <>
                <li>
                  <Link
                    className="text-decoration-none text-light"
                    to="/Profile"
                  >
                    {`Hello ${localStorage.getItem("username")}`}
                  </Link>
                </li>
                <li>
                  <NavLink onClick={handleLogout}>Logout</NavLink>
                </li>
              </>
            ) : (
              <>
                <li>
                  <Link className="text-decoration-none text-light" to="/Login">
                    Login
                  </Link>
                </li>
                <li>
                  <Link
                    className="text-decoration-none text-light"
                    to="/Register"
                  >
                    Register
                  </Link>
                </li>
              </>
            )}
          </ul>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}

export default CustomNav;
