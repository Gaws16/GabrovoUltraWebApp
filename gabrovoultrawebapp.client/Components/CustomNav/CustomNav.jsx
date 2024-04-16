import { NavLink, Navbar, Image, Container, Nav } from "react-bootstrap";

import { Link } from "react-router-dom";
import { useNavigate, useLocation } from "react-router-dom";

// eslint-disable-next-line react/prop-types
function CustomNav({ loggedIn, display, handleDisplay }) {
  const navigate = useNavigate();
  const { pathname } = useLocation();
  if (!display && pathname === "/") {
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
      className={`sticky-top  d-flex justify-content-between    bg-dark text-light`}
    >
      <Container fluid className="gap-3">
        <Link to={"/layout"}>
          <Image src="/logo.svg" width={60} height={60} />
        </Link>
        <Navbar.Toggle
          style={{ backgroundColor: "white" }}
          aria-controls="navbarScroll"
        />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav
            className="me-auto my-2 my-lg-0 text-light display-flex gap-3"
            navbarScroll
          >
            <Nav.Link>
              <Link
                to={"/layout"}
                style={{ color: "white", textDecoration: "none" }}
                href="#AboutUs"
              >
                Начало
              </Link>
            </Nav.Link>

            <Nav.Link
              to={"/distances"}
              style={{ color: "white", textDecoration: "none" }}
              href="#Distances"
            >
              Дистанции
            </Nav.Link>
            <NavLink>
              <Link
                to={"/runners"}
                style={{ color: "white", textDecoration: "none" }}
                href="#AboutUs"
              >
                Участници
              </Link>
            </NavLink>
            <NavLink>
              <Link
                to={"/results"}
                style={{ color: "white", textDecoration: "none" }}
              >
                Резултати
              </Link>
            </NavLink>

            <Nav.Link
              style={{ color: "white", textDecoration: "none" }}
              href="#AboutUs"
            >
              Контакти
            </Nav.Link>
          </Nav>

          <ul className="d-flex flex-col gap-5 text-light list-unstyled">
            {localStorage.getItem("token") && loggedIn ? (
              <>
                <li>
                  <Link
                    className="text-decoration-none text-light"
                    to="/Profile"
                  >
                    {`Hello, ${localStorage.getItem("firstName")}`}
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
