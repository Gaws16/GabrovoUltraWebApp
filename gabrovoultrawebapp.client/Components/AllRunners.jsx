import { useEffect, useState } from "react";
import { axios } from "../src/api/axios";
import Table from "react-bootstrap/Table";
const RUNNERS_URL = "/Runner?pageNumber=1&pageSize=1000";
function AllRunners() {
  const [data, setData] = useState(new Array(5).fill({}));
  useEffect(() => {
    async function fetchRunners() {
      try {
        const response = await axios.get(RUNNERS_URL);
        console.log(response.data);
        setData(response.data);
      } catch (e) {
        console.log(e);
        alert("Error loading runners");
      }
    }
    fetchRunners();
  }, []);
  console.log(data);
  return (
    <Table striped bordered hover>
      <thead>
        <tr>
          <th>#</th>
          {Object.keys(data[1])
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
  );
}

export default AllRunners;
