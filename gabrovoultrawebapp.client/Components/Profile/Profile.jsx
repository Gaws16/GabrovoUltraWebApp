import { Container, Image, Row, Col, Button, Modal } from "react-bootstrap";
import { useState } from "react";
import styles from "./Profile.module.css";
import EditProfile from "./EditProfile";
function Profile() {
  const [show, setShow] = useState(false);
  const handleShow = () => setShow((prev) => !prev);

  return (
    <Container
      fluid
      className="vh-100 gap-5 d-flex align-items-center justify-content-center"
    >
      <Row>
        <Col>
          <Image
            className={`${styles.shadow}`}
            src="/profile.jpg"
            roundedCircle
            height={300}
            width={300}
          />
        </Col>
      </Row>
      <Row>
        <Col className={`${styles.shadow} text-center p-3 rounded-5`}>
          <h1>
            {localStorage.getItem("firstName") +
              " " +
              localStorage.getItem("lastName")}
          </h1>
          <Button variant="dark" onClick={handleShow}>
            Редактирай
          </Button>
        </Col>
      </Row>
      <Row>
        {show && (
          <Modal
            show={show}
            onHide={handleShow}
            backdrop="static"
            keyboard={true}
          >
            <Modal.Header closeButton>
              <Modal.Title>Редактирай профила</Modal.Title>
            </Modal.Header>
            <Modal.Body>
              <EditProfile />
            </Modal.Body>
          </Modal>
        )}
      </Row>
    </Container>
  );
}

export default Profile;
