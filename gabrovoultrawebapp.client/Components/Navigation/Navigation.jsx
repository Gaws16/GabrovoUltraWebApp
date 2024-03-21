import React from "react";
import { useState, useEffect } from "react";

export default function Navigation() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [prevScrollPos, setPrevScrollPos] = useState(0);
  const [visible, setVisible] = useState(true);

  useEffect(() => {
    const handleScroll = () => {
      const currentScrollPos = window.scrollY;
      setVisible(prevScrollPos > currentScrollPos || currentScrollPos > 10);
      setPrevScrollPos(currentScrollPos);
    };

    window.addEventListener("scroll", handleScroll);

    return () => {
      window.removeEventListener("scroll", handleScroll);
    };
  }, [prevScrollPos, visible]);
  return (
    <nav
      className={`navbar ${
        visible
          ? "navbar-expand-lg bg-body-tertiary d-sticky sticky-top"
          : "d-none"
      } `}
    >
      <div className="container-fluid ">
        <a className="navbar-brand" href="#">
          GabrovoUltra
        </a>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarSupportedContent">
          <ul className="navbar-nav me-auto mb-2 mb-lg-0">
            <li className="nav-item">
              <a
                className="nav-link active"
                aria-current="page"
                href="#"
                onClick={() => test()}
              >
                Home
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="#">
                Link
              </a>
            </li>
            <li className="nav-item dropdown">
              <a
                className="nav-link dropdown-toggle"
                href="#"
                role="button"
                data-bs-toggle="dropdown"
                aria-expanded="false"
              >
                Dropdown
              </a>
              <ul className="dropdown-menu">
                <li>
                  <a className="dropdown-item" href="#">
                    Action
                  </a>
                </li>
                <li>
                  <a className="dropdown-item" href="#">
                    Another action
                  </a>
                </li>
                <li>
                  <hr className="dropdown-divider" />
                </li>
                <li>
                  <a className="dropdown-item" href="#">
                    Something else here
                  </a>
                </li>
              </ul>
            </li>
            <li className="nav-item">
              <a className="nav-link disabled" aria-disabled="true">
                Disabled
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link disabled" aria-disabled="true">
                Disabled
              </a>
            </li>
          </ul>
          <form className="d-flex" role="search">
            <input
              className="form-control me-2"
              type="username"
              placeholder="username"
              aria-label="Search"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            />
            <input
              className="form-control me-2"
              type="password"
              placeholder="password"
              aria-label="Search"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <button
              className="btn btn-outline-success"
              type="button"
              onClick={() => LoginUser(username, password)}
            >
              Login
            </button>
            <button
              className="btn btn-outline-success"
              type="button"
              onClick={() => RegisterUser(username, password)}
            >
              Register
            </button>
          </form>
        </div>
      </div>
    </nav>
  );
}
async function LoginUser(username, password) {
  const response = await fetch(`https://localhost:7263/api/Auth/login`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ username, password }),
  });
  if (response.ok) {
    console.log("Logged in");
    localStorage.setItem("token", (await response.json()).token);
    console.log(localStorage.getItem("token"));
  } else {
    console.log(await response.json());
  }
}
async function RegisterUser(username, password) {
  const response = await fetch(`https://localhost:7263/api/Auth/register`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ username, password }),
  });
  console.log(await response.json());
}
async function test() {
  const response = await fetch(`https://localhost:7263/api/Test`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
  });
  console.log(await response.json());
}
