import { useState } from "react";
import Button from "react-bootstrap/Button";
import Col from "react-bootstrap/Col";
import Form from "react-bootstrap/Form";
import Row from "react-bootstrap/Row";
import styles from "./Register.module.css";
import { Container } from "react-bootstrap";
import { useNavigate } from "react-router";
import { axios } from "../../src/api/axios";
const REGISTER_URL = "/Auth/Register";
function Register() {
  const [validated, setValidated] = useState(false);
  const navigate = useNavigate();
  const [formData, setFormData] = useState({
    username: "",
    password: "",
    confirmPassword: "",
    firstName: "",
    lastName: "",
    gender: "Male",
    age: 1,
    team: "",
    city: "",
    country: "",
    Roles: ["Reader"],
  });

  const [errors, setErrors] = useState({});
  const handleSubmit = async (event) => {
    const form = event.currentTarget;
    event.preventDefault();

    if (form.checkValidity === false) {
      event.stopPropagation();
    }
    if (formData.password !== formData.confirmPassword) {
      setErrors({ Password: "Passwords do not match" });
      return;
    }
    try {
      await axios.post(REGISTER_URL, formData);
    } catch (error) {
      if (error?.response?.data?.errors) {
        setErrors(error.response.data.errors);
        return;
      }
      setErrors({ message: error.response.data });
      return;
    }
    setValidated(true);
    navigate("/login");
  };

  return (
    <Container
      className={`${styles.background} d-flex  justify-content-center align-items-center`}
      fluid
    >
      <Form
        noValidate
        validated={validated}
        onSubmit={handleSubmit}
        className={`${styles.formContainer} p-5 m-5 rounded-3`}
      >
        <Row>
          <Form.Group as={Col} xs={12} md={4} controlId="formEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control
              required
              type="email"
              placeholder="Enter email"
              value={formData.email}
              onChange={(e) =>
                setFormData({ ...formData, username: e.target.value })
              }
            />
            <span className="text-danger">{errors?.Username}</span>
          </Form.Group>
          <Form.Group as={Col} xs={12} md={4} controlId="formPassword">
            <Form.Label>Password</Form.Label>
            <Form.Control
              required
              minLength={6}
              type="password"
              placeholder="Password"
              value={formData.password}
              onChange={(e) =>
                setFormData({ ...formData, password: e.target.value })
              }
            />
            <span className="text-danger">{errors?.Password}</span>
          </Form.Group>
          <Form.Group as={Col} xs={12} md={4} controlId="formConfirmPassword">
            <Form.Label>Confirm Password</Form.Label>
            <Form.Control
              required
              minLength={6}
              type="password"
              placeholder="Confirm Password"
              value={formData.confirmPassword}
              onChange={(e) =>
                setFormData({ ...formData, confirmPassword: e.target.value })
              }
            />
            {formData.password !== formData.confirmPassword && (
              <span className="text-danger">Passwords do not match! </span>
            )}
            <span className="text-danger">{errors?.Password} </span>
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} xs={12} md={6} controlId="formFirstNane">
            <Form.Label>First Name</Form.Label>
            <Form.Control
              required
              type="text"
              placeholder="First Name"
              value={formData.firstName}
              onChange={(e) =>
                setFormData({ ...formData, firstName: e.target.value })
              }
            />
            <span className="text-danger">{errors?.FirstName}</span>
          </Form.Group>
          <Form.Group as={Col} xs={12} md={6}>
            <Form.Label>Last Name</Form.Label>
            <Form.Control
              required
              minLength={2}
              maxLength={50}
              type="text"
              placeholder="Last Name"
              value={formData.lastName}
              onChange={(e) =>
                setFormData({ ...formData, lastName: e.target.value })
              }
            />
            <span className="text-danger">{errors?.LastName}</span>
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} xs={12} md={5}>
            <Form.Label>Gender:</Form.Label>
            <Form.Control
              value={formData.gender}
              onChange={(e) =>
                setFormData({ ...formData, gender: e.target.value })
              }
              required
              as="select"
            >
              <option>Male</option>
              <option>Female</option>
              <option>Other</option>
            </Form.Control>
            <span className="text-danger">{errors?.Gender}</span>
          </Form.Group>
          <Form.Group as={Col} xs={12} md={2}>
            <Form.Label>Age</Form.Label>
            <Form.Control
              required
              type="number"
              min={1}
              max={100}
              placeholder="Age"
              value={formData.age}
              onChange={(e) =>
                setFormData({
                  ...formData,
                  age: e.target.valueAsNumber,
                })
              }
            />
            <span className="text-danger">{errors?.Age}</span>
          </Form.Group>
          <Form.Group as={Col} xs={12} md={5}>
            <Form.Label>Team</Form.Label>
            <Form.Control
              required
              minLength={5}
              maxLength={50}
              type="text"
              placeholder="Team"
              value={formData.team}
              onChange={(e) =>
                setFormData({ ...formData, team: e.target.value })
              }
            />
            <span className="text-danger">{errors?.Team}</span>
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} xs={6} md={6}>
            <Form.Label>City</Form.Label>
            <Form.Control
              required
              minLength={3}
              maxLength={50}
              type="text"
              placeholder="City"
              value={formData.city}
              onChange={(e) =>
                setFormData({ ...formData, city: e.target.value })
              }
            />
            <span className="text-danger">{errors?.City}</span>
          </Form.Group>
          <Form.Group as={Col} xs={6} md={6}>
            <Form.Label>Country</Form.Label>
            <Form.Control
              required
              minLength={3}
              maxLength={50}
              type="text"
              placeholder="Country"
              value={formData.country}
              onChange={(e) =>
                setFormData({ ...formData, country: e.target.value })
              }
            />
            <span className="text-danger">{errors?.Country}</span>
          </Form.Group>
        </Row>
        <Button className="mt-3" type="submit">
          Register
        </Button>
        <div>
          {errors?.message && (
            <span className="text-danger">{errors?.message}</span>
          )}
        </div>
      </Form>
    </Container>
  );
}

export default Register;
