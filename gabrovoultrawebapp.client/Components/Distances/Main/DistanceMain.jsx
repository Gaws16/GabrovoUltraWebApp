import { useEffect, useState } from "react";
import { Card, Container, Button, Row, Image } from "react-bootstrap";
import styles from "./DistanceMain.module.css";
import JoinDIstance from "../AddToDistanceModal/JoinDistance";
const API_URI = "https://localhost:7263/api/Distances";
function DistancesMain() {
  const [distances, setDistances] = useState([]);

  useEffect(() => {
    async function fetchDistances() {
      try {
        const response = await fetch(API_URI, {
          method: "GET",
          headers: {
            "Content-Type": "application/json",
          },
        });

        setDistances(await response.json());
      } catch {
        alert("Error loading Distances!");
      }
    }
    fetchDistances();
  }, []);
  return (
    <Container id="Distances" fluid className="m-auto p-5">
      <Row xs={12} md={4} className="d-flex justify-content-center gap-5">
        {distances.map((distance) => (
          <Card
            key={distance.id}
            style={{ width: "18rem" }}
            className="text-center p-3"
          >
            <Image
              fluid
              rounded
              src={`${distance.imagePath}`}
              className={`${styles.cardImage} ${styles.shadow}`}
            />
            <Card.Body>
              <Card.Title>{distance.name}</Card.Title>
              <Card.Text>{distance.description}</Card.Text>
              <JoinDIstance data={distance} />
            </Card.Body>
          </Card>
        ))}
      </Row>
    </Container>
  );
}

export default DistancesMain;
