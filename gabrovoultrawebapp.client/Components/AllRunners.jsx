import { useEffect, useState } from "react";
import ResultTable from "./ResultTable";
export default function AllRunners() {
  const [data, setData] = useState([]);
  useEffect(() => {
    async function fetchRunners() {
      try {
        const response = await fetch(
          "https://localhost:7263/api/Runner?pageNumber=1&pageSize=1000"
        );
        setData(await response.json());
      } catch {
        alert("Error loading runners");
      }
    }
    fetchRunners();
  }, []);
  return (
    <div>
      <ResultTable data={data} />
    </div>
  );
}
