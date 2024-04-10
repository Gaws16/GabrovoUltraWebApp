import { useEffect, useRef, useState } from "react";
import { axios } from "../src/api/axios";
import {
  Table,
  Container,
  Form,
  Row,
  Col,
  Button,
  Pagination,
} from "react-bootstrap";
const RUNNERS_URL = "/Runner";
function AllRunners() {
  const [data, setData] = useState(new Array(5).fill({}));
  const [filterOn, setFilterOn] = useState("firstName");
  const [filterQuery, setFilterQuery] = useState("");
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize] = useState(10);
  const [isAscending, setIsAscending] = useState(false);
  const numberOfPages = useRef(0);

  useEffect(() => {
    async function getNumberOfPages() {
      try {
        const response = await axios.get(`${RUNNERS_URL}/count`);
        numberOfPages.current = Math.ceil(response.data / pageSize);
      } catch (e) {
        console.log(e);
        alert("Error loading runners");
      }
    }
    getNumberOfPages();
  }, []);
  useEffect(() => {
    async function fetchRunners() {
      try {
        const response = await axios.get(
          `${RUNNERS_URL}?filterOn=${filterOn}&filterQuery=${filterQuery}&sortBy=${filterOn}&isAscending=${isAscending}&pageNumber=${pageNumber}&pageSize=${pageSize}`
        );

        setData(response.data);
      } catch (e) {
        console.log(e);
        alert("Error loading runners");
      }
    }
    fetchRunners();
  }, [pageNumber, pageSize, filterOn, filterQuery, isAscending]);

  return (
    <Container fluid className="m-auto text-center">
      <Form className="m-5 ">
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Сортирай по:</Form.Label>
            <Form.Control
              onChange={(e) => setIsAscending(e.target.value)}
              as="select"
            >
              <option value={true}>Възходящ</option>
              <option value={false}>Низходящ</option>
            </Form.Control>
          </Form.Group>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Търси по:</Form.Label>
            <Form.Control
              onChange={(e) => setFilterOn(e.target.value)}
              as="select"
            >
              <option value={"firstName"}>Име</option>
              <option value={"lastName"}>Фамилия</option>
              <option value={"City"}>Град</option>
              <option value={"Country"}>Държава</option>
              <option value={"team"}>Отбор</option>
              <option value={"gender"}>Пол</option>
              <option value={"age"}>Възраст</option>
              <option value={"distanceid"}>Дистанция</option>
              <option value={"startingNumber"}>Стартов Номер</option>
            </Form.Control>
          </Form.Group>

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
            </tr>
          ))}
        </tbody>
      </Table>
      <Pagination className="flex justify-content-center">
        <Pagination.Prev
          onClick={() => {
            pageNumber > 1 && setPageNumber((prev) => prev - 1);
          }}
        />
        {new Array(numberOfPages.current).fill(0).map((_, index) => {
          return (
            <Pagination.Item
              active={index + 1 === pageNumber}
              key={index}
              onClick={() => {
                setPageNumber(() => index + 1);
              }}
            >
              {index + 1}
            </Pagination.Item>
          );
        })}
        <Pagination.Next
          onClick={() => {
            pageNumber < numberOfPages.current &&
              setPageNumber((prev) => prev + 1);
          }}
        />
      </Pagination>
    </Container>
  );
}

export default AllRunners;
