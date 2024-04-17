import { useEffect, useState } from "react";
import {
  Container,
  Table,
  Form,
  Row,
  Col,
  Button,
  Modal,
} from "react-bootstrap";
import EditUser from "./EditUser.jsx";
import { axiosPrivate } from "../../src/api/axios";
import EditUserModal from "./EditUserModal.jsx";
const USERS_URL = "/Admin/";
export default function AdminPanel() {
  const [errors, setErrors] = useState({});
  const [data, setData] = useState(new Array(5).fill({}));
  const [filterQuery, setFilterQuery] = useState("");
  const [isAscending, setIsAscending] = useState(false);

  useEffect(() => {
    async function fetchRunners() {
      try {
        const response = await axiosPrivate.get(`${USERS_URL}`);

        setData(response.data);
      } catch (e) {
        console.log(e);
      }
    }
    fetchRunners();
  }, [isAscending]);
  async function DeleteUser(id) {
    try {
      await axiosPrivate.delete(`${USERS_URL}Delete?id=${id}`);
    } catch (e) {
      setErrors(e.response?.data?.errors);
    }
    setIsAscending(!isAscending);
  }

  return (
    <Container fluid className="m-auto text-center">
      <Form className="m-5 ">
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Търси</Form.Label>
            <Form.Control
              value={filterQuery}
              onChange={(e) => setFilterQuery(e.target.value)}
              type="text"
              placeholder="Търси"
            />
          </Form.Group>
        </Row>
      </Form>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>#</th>
            {data[0] &&
              Object.keys(data[0])
                .filter((k) => k !== "id")
                .map((key, index) => {
                  return <th key={index}>{key}</th>;
                })}
          </tr>
        </thead>
        <tbody>
          {data.map((row, index) => (
            <tr key={index}>
              <td>{index + 1}</td>
              {Object.keys(row)
                .filter((k) => k !== "id")
                .map((key, index) => {
                  return <td key={index}>{row[key]}</td>;
                })}
              <td className="d-flex gap-3">
                <EditUserModal data={row} />
                <Button onClick={() => DeleteUser(row.id)} variant="dark">
                  Delete
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </Container>
  );
}
