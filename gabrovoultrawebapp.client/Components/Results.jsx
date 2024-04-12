import { Container, Table, Pagination, Form, Row, Col } from "react-bootstrap";
import { useState, useRef, useEffect } from "react";
import { axios } from "../src/api/axios";

const RESULTS_URL = "/Results";
const RACES_URL = "/Race";
const DISTANCES_URL = "/Distances";
function Results() {
  const [data, setData] = useState(new Array(5).fill({}));
  const [selectData, setSelectData] = useState({
    races: new Array(5).fill({}),
    distances: new Array(5).fill({}),
  });
  const [filterOn, setFilterOn] = useState("firstName");
  const [filterQuery, setFilterQuery] = useState("");
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize] = useState(10);
  const numberOfPages = useRef(0);

  useEffect(() => {
    async function getRaces() {
      try {
        const raceResponse = await axios.get(`${RACES_URL}`);
        const distanceResponse = await axios.get(`${DISTANCES_URL}`);
        const resultResponse = await axios.get(`${RESULTS_URL}`);
        setData(resultResponse.data);
        setSelectData((prev) => ({
          ...prev,
          races: raceResponse.data,
          distances: distanceResponse.data,
        }));
      } catch (e) {
        console.log(e);
      }
    }
    getRaces();
  }, []);
  return (
    <Container>
      <Form>
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Резултати за </Form.Label>
            <Form.Control
              onChange={(e) => setFilterQuery(e.target.value)}
              as="select"
            >
              {selectData.races.map((race, index) => {
                return (
                  <option key={index} value={race.name}>
                    {race.name}
                  </option>
                );
              })}
            </Form.Control>
          </Form.Group>
        </Row>
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Дистанция </Form.Label>
            <Form.Control
              onChange={(e) => setFilterQuery(e.target.value)}
              as="select"
            >
              {selectData.distances.map((distance, index) => {
                return (
                  <option key={index} value={distance.name}>
                    {distance.name}
                  </option>
                );
              })}
            </Form.Control>
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

export default Results;
