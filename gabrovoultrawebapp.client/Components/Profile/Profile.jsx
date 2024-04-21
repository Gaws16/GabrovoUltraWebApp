import { Container, Image, Row, Col, Button, Modal } from "react-bootstrap";
import { useState, useEffect } from "react";
import { axiosPrivate } from "../../src/api/axios";
import useAuth from "../../src/hooks/useAuth";
import styles from "./Profile.module.css";
import EditProfile from "./EditProfile";
function Profile() {
  const [show, setShow] = useState(false);
  const handleShow = () => setShow((prev) => !prev);
  const { auth } = useAuth();
  const [formInputs, setFormInputs] = useState({
    id: "",
    firstName: "",
    lastName: "",
    country: "",
    city: "",
    age: "",
    team: "",
  });
  useEffect(() => {
    async function getProfile() {
      try {
        const response = await axiosPrivate.get("/Runner/Edit", {
          headers: {
            "Content-Type": "application/json",
            withCredentials: true,
            Authorization: `Bearer ${auth?.accessToken}`,
          },
        });
        setFormInputs(response.data);
      } catch (e) {
        console.log(e);
      }
    }
    getProfile();
  }, []);
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
          <h1>{auth?.firstName + " " + auth?.lastName}</h1>
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
              <EditProfile
                formInputs={formInputs}
                setFormInputs={setFormInputs}
              />
            </Modal.Body>
          </Modal>
        )}
      </Row>
    </Container>
  );
}

export default Profile;
