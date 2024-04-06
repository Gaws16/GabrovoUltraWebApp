import { useState } from "react";
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";

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
          <Modal.Body>
            {data.description}
            Lorem ipsum dolor sit, amet consectetur adipisicing elit. Atque
            doloremque provident soluta earum quibusdam odit. Quas vel natus
            ipsum error beatae pariatur, harum earum doloremque laboriosam
            quisquam, deserunt et rerum!
          </Modal.Body>
          <Modal.Footer>
            <Button variant="secondary" onClick={handleShow}>
              Затвори
            </Button>
            <Button variant="primary">Запиши се за дистанцията</Button>
          </Modal.Footer>
        </Modal>
      )}
    </>
  );
}

export default JoinDistance;

async function handleSignUpForDistance() {}
