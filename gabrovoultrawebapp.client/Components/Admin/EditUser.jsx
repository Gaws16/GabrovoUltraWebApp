import { Form, Button, Row, Col } from "react-bootstrap";
import { useState, useEffect } from "react";
import { axiosPrivate } from "../../src/api/axios";
const DISTANCES_URL = "/Distances";
const RACES_URL = "/Race";
const UPDATE_URL = "/Admin/Update";
function EditUser({ data }) {
  const [errors, setErrors] = useState({});
  const [formInputs, setFormInputs] = useState({
    ...data,
    raceId: 1,
    distanceId: 1,
  });
  const [selectData, setSelectData] = useState({
    races: new Array(5).fill({}),
    distances: new Array(5).fill({}),
  });
  useEffect(() => {
    async function getRaces() {
      try {
        const raceResponse = await axiosPrivate.get(`${RACES_URL}`);
        const distanceResponse = await axiosPrivate.get(`${DISTANCES_URL}`);

        setSelectData((prev) => ({
          ...prev,
          races: raceResponse.data,
          distances: distanceResponse.data,
        }));
      } catch (e) {
        alert("Error loading data");
      }
    }
    getRaces();
  }, []);
  async function handleSubmit(e) {
    e.preventDefault();
    try {
      await axiosPrivate.put(`${UPDATE_URL}/${formInputs.id}`, formInputs);
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
      <Row>
        <Form.Group as={Col} md={6} className="mb-3">
          <Form.Label>Състезание </Form.Label>
          <Form.Control
            onChange={(e) =>
              setFormInputs({ ...formInputs, raceId: e.target.value })
            }
            as="select"
            className="form-select"
          >
            {selectData.races.map((race, index) => {
              return (
                <option key={index} value={race.id}>
                  {race.name}
                </option>
              );
            })}
          </Form.Control>
        </Form.Group>

        <Form.Group as={Col} md={6} className="mb-3">
          <Form.Label>Дистанция </Form.Label>
          <Form.Control
            as="select"
            className="form-select"
            onChange={(e) =>
              setFormInputs({
                ...formInputs,
                distanceId: e.target.value,
              })
            }
          >
            {selectData.distances.map((distnace, index) => {
              return (
                <option key={index} value={distnace.id}>
                  {distnace.name}
                </option>
              );
            })}
          </Form.Control>
        </Form.Group>
      </Row>
      <Button type="submit" variant="dark">
        Промени
      </Button>
    </Form>
  );
}

export default EditUser;
