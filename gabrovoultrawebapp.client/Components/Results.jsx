import { Container, Table, Pagination, Form, Row, Col } from "react-bootstrap";
import { useState, useRef, useEffect } from "react";
import { axios } from "../src/api/axios";

const RESULTS_URL = "/Results";
const RACES_URL = "/Race";
const DISTANCES_URL = "/Distances";
function Results() {
  const [results, setResults] = useState(new Array(5).fill({}));
  const [selectData, setSelectData] = useState({
    races: new Array(5).fill({}),
    distances: new Array(5).fill({}),
  });
  const [queryParameters, setQueryParameters] = useState({
    distanceId: 1,
    raceId: 1,
  });
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize] = useState(10);
  const numberOfPages = useRef(0);

  useEffect(() => {
    async function getRaces() {
      try {
        const raceResponse = await axios.get(`${RACES_URL}`);
        const distanceResponse = await axios.get(`${DISTANCES_URL}`);
        const resultsResponse = await axios.get(
          `${RESULTS_URL}/${queryParameters.raceId}, ${queryParameters.distanceId}?isAscending=true&pageNumber=1&pageSize=1000`
        );
        setResults(resultsResponse.data);
        numberOfPages.current = Math.ceil(
          resultsResponse.data.length / pageSize
        );
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
  }, [queryParameters, pageSize, pageNumber]);
  return (
    <Container>
      <Form>
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Резултати за </Form.Label>
            <Form.Control
              onChange={(e) =>
                setQueryParameters((prev) => ({
                  ...prev,
                  raceId: e.target.value,
                }))
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
        </Row>
        <Row>
          <Form.Group as={Col} md={4} className="mb-3">
            <Form.Label>Дистанция </Form.Label>
            <Form.Control
              onChange={(e) =>
                setQueryParameters((prev) => ({
                  ...prev,
                  distanceId: e.target.value,
                }))
              }
              as="select"
              className="form-select"
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
      </Form>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>#</th>
            {results[0] &&
              Object.keys(results[0])
                .filter((k) => k !== "id")
                .map((key, index) => {
                  return <th key={index}>{key}</th>;
                })}
          </tr>
        </thead>
        <tbody>
          {results.map((row, index) => (
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
