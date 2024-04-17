import { useState } from "react";
import { Button, Modal } from "react-bootstrap/";
import EditUser from "./EditUser.jsx";
function EditUserModal({ data }) {
  const [show, setShow] = useState(false);
  const handleShow = () => setShow((prev) => !prev);
  return (
    <>
      <Button onClick={handleShow} variant="dark">
        Edit
      </Button>
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
            <EditUser data={data} />
          </Modal.Body>
        </Modal>
      )}
    </>
  );
}

export default EditUserModal;
