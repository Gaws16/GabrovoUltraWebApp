import { useState } from "react";
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";
const API_URL = "https://localhost:7263/api/Registration";
function JoinDistance({ data }) {
  const [show, setShow] = useState(false);
  const handleShow = () => setShow((prev) => !prev);
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
            <Button
              variant="primary"
              onClick={() => handleSignUpForDistance(data.id)}
            >
              Запиши се за дистанцията
            </Button>
          </Modal.Footer>
        </Modal>
      )}
    </>
  );
}

export default JoinDistance;

async function handleSignUpForDistance(id) {
  const response = await fetch(API_URL, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
    body: JSON.stringify({ Id: id }),
  });

  const data = await response.json();
  console.log(data);
  if (response.status === 401 || response.status === 403) {
    alert("You must be logged in to sign up for a distance!");
    return;
  }
}
