import { Form, Button, Container, Col, Row } from "react-bootstrap";
import styles from "./LoginContext.module.css";
import { useRef, useState, useEffect } from "react";
import useAuth from "../../src/hooks/useAuth";
import { axios } from "../../src/api/axios";
import { Link, useNavigate, useLocation } from "react-router-dom";
const LOGIN_URL = "/Auth/Login";
function Login() {
  const { setAuth } = useAuth();

  const navigate = useNavigate();
  const location = useLocation();
  const from = location?.state?.from || { pathname: "/" };
  const userRef = useRef();
  const errRef = useRef();

  const [user, setUser] = useState("");
  const [pwd, setPwd] = useState("");
  const [errmsg, setErrMsg] = useState("");

  useEffect(() => {
    userRef.current.focus();
  }, []);
  useEffect(() => {
    setErrMsg("");
  }, [user, pwd]);
  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post(
        LOGIN_URL,
        JSON.stringify({ Username: user, Password: pwd }),
        {
          headers: {
            "Content-Type": "application/json",
            withCredentials: true,
          },
        }
      );
      console.log("asd");
      const firstName = response?.data?.firstName;
      const lastName = response?.data?.lastName;
      const accessToken = response?.data?.jwtToken;
      const roles = response?.data?.roles;
      setAuth({ user, pwd, roles, accessToken, firstName, lastName });
      setUser("");
      setPwd("");
      navigate(from, { replace: true });
    } catch (err) {
      if (!err?.response) {
        setErrMsg("No server response");
      } else if (err.response?.status === 400) {
        console.log(err.response);
        setErrMsg("Invalid username or password");
      } else if (err.response?.status === 401) {
        setErrMsg("Unauthorized access");
      } else {
        setErrMsg("Login failed");
      }
      errRef.current.focus();
    }
  };

  return (
    <Container
      fluid
      className={`${styles.background} d-flex justify-content-center align-items-center`}
    >
      <Form
        noValidate
        onSubmit={handleSubmit}
        className={`${styles.formContainer} m-4 p-4 rounded-3 `}
      >
        <Row>
          <Form.Group as={Col} md={12}>
            <Form.Label>Email address</Form.Label>
            <Form.Control
              required
              value={user}
              onChange={(e) => setUser(e.target.value)}
              type="text"
              id="username"
              ref={userRef}
              autoComplete="off"
              placeholder="Enter username"
            />
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} className="mb-3">
            <Form.Label>Password</Form.Label>
            <Form.Control
              required
              type="password"
              placeholder="Password"
              value={pwd}
              onChange={(e) => setPwd(e.target.value)}
            />
          </Form.Group>
        </Row>
        <Row>
          <Button variant="primary" type="submit">
            Login
          </Button>
          <span ref={errRef} className="text-danger">
            {errmsg}
          </span>
        </Row>
      </Form>
    </Container>
  );
}

export default Login;
