import { NavLink, Navbar, Image, Container, Nav } from "react-bootstrap";
import useAuth from "../../src/hooks/useAuth";
import { Link } from "react-router-dom";
import { useNavigate, useLocation } from "react-router-dom";

// eslint-disable-next-line react/prop-types
function CustomNav() {
  const navigate = useNavigate();
  const { pathname } = useLocation();
  const { auth, setAuth } = useAuth();
  const handleLogout = () => {
    setAuth({});
    navigate("/");
  };
  return (
    <Navbar
      collapseOnSelect
      expand="lg"
      className={`sticky-top  d-flex justify-content-between fill-available   bg-dark text-light`}
      style={{
        width: "-webkit-fill-available",
      }}
    >
      <Container fluid className="gap-3">
        <Link to={"/"}>
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
            <Link to={"/"} style={{ color: "white", textDecoration: "none" }}>
              Начало
            </Link>

            {pathname === "/" && (
              <Link
                style={{ color: "white", textDecoration: "none" }}
                href="#Distances"
              >
                Дистанции
              </Link>
            )}

            <Link
              to={"/runners"}
              style={{ color: "white", textDecoration: "none" }}
            >
              Участници
            </Link>

            <Link
              to={"/results"}
              style={{ color: "white", textDecoration: "none" }}
            >
              Резултати
            </Link>
          </Nav>
          <Nav className="d-flex gap-3">
            {auth?.user !== undefined ? (
              <>
                <Link
                  style={{ color: "white", textDecoration: "none" }}
                  to={"/profile"}
                >
                  Hello, {auth?.firstName}
                </Link>

                <Link
                  onClick={handleLogout}
                  style={{ color: "white", textDecoration: "none" }}
                >
                  Изход
                </Link>
              </>
            ) : (
              <>
                <Link
                  to={"LoginCotext"}
                  style={{ color: "white", textDecoration: "none" }}
                >
                  Вход
                </Link>

                <Link
                  to={"/register"}
                  style={{ color: "white", textDecoration: "none" }}
                >
                  Регистрация
                </Link>
              </>
            )}
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}

export default CustomNav;
