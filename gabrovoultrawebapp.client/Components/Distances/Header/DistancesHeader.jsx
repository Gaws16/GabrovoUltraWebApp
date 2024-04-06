import { Container, Row, Col } from "react-bootstrap";
import styles from "./DistancesHeader.module.css";
function DistancesHeader() {
  return (
    <Container fluid className="d-flex">
      <Container fluid className={`${styles.banner} p-5 m-3  rounded-3`}>
        <Row>
          <Col className={` ${styles.wrapper}`}>
            <span data-text="Изберете си "></span>
            <span data-text="приключение"></span>
          </Col>
        </Row>
      </Container>
    </Container>
  );
}

export default DistancesHeader;
