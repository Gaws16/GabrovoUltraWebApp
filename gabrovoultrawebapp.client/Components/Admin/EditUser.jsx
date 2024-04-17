import { Form, Button, Row, Col } from "react-bootstrap";
import { useState, useEffect } from "react";
import { axiosPrivate } from "../../src/api/axios";

function EditUser({ data }) {
  const [errors, setErrors] = useState({});
  const [formInputs, setFormInputs] = useState({
    ...data,
  });
  async function handleSubmit(e) {
    e.preventDefault();
    try {
      await axiosPrivate.put(`/Runner/user/${formInputs.id}`, formInputs);
    } catch (e) {
      if (e?.response?.data?.errors) {
        setErrors(e.response.data.errors);
        return;
      }
      setErrors({ message: e.response.data });
      return;
    }
  }
  return (
    <Form onSubmit={handleSubmit} className="text-center">
      <Row>
        <Form.Group as={Col} className="mb-3" id="EditProfile">
          <Form.Label>Име</Form.Label>
          <Form.Control
            type="text"
            value={formInputs.firstName}
            onChange={(e) =>
              setFormInputs({ ...formInputs, firstName: e.target.value })
            }
            placeholder="Име"
          />
          <span className="text-danger">{errors?.FirstName}</span>
        </Form.Group>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Фамилия</Form.Label>
          <Form.Control
            value={formInputs.lastName}
            onChange={(e) =>
              setFormInputs({ ...formInputs, lastName: e.target.value })
            }
            type="text"
            placeholder="Фамилия"
          />
          <span className="text-danger">{errors?.LastName}</span>
        </Form.Group>
      </Row>
      <Row>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Държава</Form.Label>
          <Form.Control
            value={formInputs.country}
            onChange={(e) =>
              setFormInputs({ ...formInputs, country: e.target.value })
            }
            type="text"
            placeholder="Държава"
          />
          <span className="text-danger">{errors?.Country}</span>
        </Form.Group>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Град</Form.Label>
          <Form.Control
            value={formInputs.city}
            onChange={(e) =>
              setFormInputs({ ...formInputs, city: e.target.value })
            }
            type="text"
            placeholder="Град"
          />
        </Form.Group>
      </Row>
      <Row>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Години</Form.Label>
          <Form.Control
            value={formInputs.age}
            onChange={(e) =>
              setFormInputs({ ...formInputs, age: e.target.value })
            }
            type="text"
            placeholder="Години"
          />
          <span className="text-danger">{errors?.Age}</span>
        </Form.Group>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Отбор</Form.Label>
          <Form.Control
            value={formInputs.team}
            onChange={(e) =>
              setFormInputs({ ...formInputs, team: e.target.value })
            }
            type="text"
            placeholder="Отбор"
          />
          <span className="text-danger">{errors?.Team}</span>
        </Form.Group>
      </Row>
      <Row>
        <Form.Group as={Col} className="mb-3" controlId="EditProfile">
          <Form.Label>Резултат</Form.Label>
          <Form.Control
            value={formInputs.result}
            onChange={(e) =>
              setFormInputs({ ...formInputs, result: e.target.value })
            }
            type="text"
            placeholder="Резултат"
          />
          <span className="text-danger">{errors?.Result}</span>
        </Form.Group>
      </Row>
      <Button type="submit" variant="dark">
        Промени
      </Button>
      {errors?.message && (
        <span className="text-danger">{errors?.message}</span>
      )}
    </Form>
  );
}

export default EditUser;
