import { useState } from "react";
import useAuth from "../../../src/hooks/useAuth";
import { axiosPrivate } from "../../../src/api/axios";
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";
import { OverlayTrigger, Popover } from "react-bootstrap/";
const API_URL = "https://localhost:7263/api/Registration";
const ADD_TO_DISTANCE_URL = "/Registration";
function JoinDistance({ data }) {
  const [show, setShow] = useState(false);
  const { auth } = useAuth();
  const handleShow = () => setShow((prev) => !prev);
  const [popoverText, setPopOverText] = useState("");
  async function handleSignUpForDistance(id) {
    console.log(id);
    try {
      const response = await axiosPrivate.post(
        ADD_TO_DISTANCE_URL,
        { Id: id },
        {
          headers: {
            "Content-Type": "application/json",
            Authorization: `Bearer ${auth?.accessToken}`,
          },
          withCredentials: true,
        }
      );

      if (response.status === 201) {
        setPopOverText("Успешно записан за дистанцията!");
      }
    } catch (err) {
      if (err.response.status === 400) {
        setPopOverText(err.response.data);
      }
      // setPopOverText(response.data);
      if (err.response.status === 401 || err.response.status === 403) {
        setPopOverText(
          "Трябва да сте влезли в профила си, за да се запишете за дистанция!"
        );
        return;
      }
    }
  }
  const popover = (
    <Popover id="popover-basic">
      <Popover.Body>{popoverText}</Popover.Body>
    </Popover>
  );
  return (
    <>
      <Button onClick={handleShow} variant="dark">
        Повече информация
      </Button>
      {show && (
        <Modal
          show={show}
          onHide={handleShow}
          backdrop="static"
          keyboard={true}
        >
          <Modal.Header closeButton>
            <Modal.Title>{data.name}</Modal.Title>
          </Modal.Header>
          <Modal.Body>{data.description}</Modal.Body>
          <Modal.Footer>
            <Button variant="secondary" onClick={handleShow}>
              Затвори
            </Button>
            <OverlayTrigger placement="top" trigger="click" overlay={popover}>
              <Button
                variant="primary"
                onClick={() => handleSignUpForDistance(data.id)}
              >
                Запиши се за дистанцията
              </Button>
            </OverlayTrigger>
          </Modal.Footer>
        </Modal>
      )}
    </>
  );
}

export default JoinDistance;
