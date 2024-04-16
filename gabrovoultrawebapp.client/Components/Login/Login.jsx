import { Form, Button, Container, Col, Row } from "react-bootstrap";
import styles from "./Login.module.css";
import { useState } from "react";
import { useNavigate } from "react-router";
import { axios } from "../../src/api/axios";
const LOGIN_URL = "/Auth/Login";
function Login() {
  const [loginRequest, setLoginRequest] = useState({
    username: "",
    password: "",
  });
  const [errors, setErrors] = useState({});
  const navigate = useNavigate();
  const handleSubmit = async (event) => {
    event.preventDefault();
    try {
      const response = await axios.post(LOGIN_URL, loginRequest);

      if (response?.data?.jwtToken !== undefined) {
        localStorage.setItem("token", response.data.jwtToken);
        localStorage.setItem("firstName", response.data.firstName);
        localStorage.setItem("lastName", response.data.lastName);
        localStorage.setItem("role", response.data.role);
        localStorage.setItem("expirationTime", response.data.expirationTime);
      }
      navigate("/layout");
    } catch (e) {
      if (e.response?.data?.errors === undefined) {
        setErrors({ message: "Invalid username or password" });
        return;
      }

      if (e.response?.status === 400) {
        setErrors({
          Password: e.response?.data?.errors?.Password,
          Username: e.response?.data?.errors?.Username,
        });
        return;
      }
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
              value={loginRequest.username}
              onChange={(e) =>
                setLoginRequest({ ...loginRequest, username: e.target.value })
              }
              type="email"
              placeholder="Enter email"
            />
            <span className="text-danger">{errors?.Username}</span>
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} className="mb-3">
            <Form.Label>Password</Form.Label>
            <Form.Control
              type="password"
              placeholder="Password"
              value={loginRequest.password}
              onChange={(e) =>
                setLoginRequest({ ...loginRequest, password: e.target.value })
              }
            />
            <span className="text-danger">{errors?.Password}</span>
          </Form.Group>
        </Row>
        <Row>
          <Button variant="primary" type="submit">
            Login
          </Button>
          <span className="text-danger">{errors?.message}</span>
        </Row>
      </Form>
    </Container>
  );
}

export default Login;
