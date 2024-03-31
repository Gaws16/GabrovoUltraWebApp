import Table from "react-bootstrap/Table";

function ResultTable({ data }) {
  return (
    <Table striped bordered hover>
      <thead>
        <tr>
          <th>#</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Gender</th>
          <th>Team</th>
          <th>Starting Number</th>
        </tr>
      </thead>
      <tbody>
        {data.map((row, index) => (
          <tr key={index}>
            <td>{index + 1}</td>
            <td>{row.firstName}</td>
            <td>{row.lastName}</td>
            <td>{row.gender}</td>
            <td>{row.team}</td>
            <td>{row.startingNumber}</td>
          </tr>
        ))}
      </tbody>
    </Table>
  );
}

export default ResultTable;
