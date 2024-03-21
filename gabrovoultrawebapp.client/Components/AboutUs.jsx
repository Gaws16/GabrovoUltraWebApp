import { Col, Container, Image } from "react-bootstrap";
function AboutUs() {
  return (
    <Container className="d-flex mt-5 mb-5 gap-5" id="AboutUs">
      <Col className="text-center m-auto">
        <h1>About Us</h1>
        <p>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti fuga
          quos, in iure architecto facere doloribus maxime doloremque
          repudiandae ab quo molestiae. Corrupti dolorum voluptates, itaque
          harum at molestias illum. Lorem ipsum dolor, sit amet consectetur
          adipisicing elit. Temporibus non, distinctio eius recusandae nam
          veniam reiciendis modi nobis ab perspiciatis illo aliquam repudiandae
          debitis cum asperiores quae nihil unde. Laboriosam? Lorem ipsum dolor
          sit amet consectetur adipisicing elit. Natus odio voluptas nihil
          aperiam quia non dolore eveniet eligendi tenetur voluptates illo, sit
          aut reprehenderit minus voluptatibus praesentium doloribus minima.
          Deserunt.
        </p>
      </Col>
      <Col>
        <Image src="public/Reka.jpg" fluid thumbnail="true" />
      </Col>
    </Container>
  );
}

export default AboutUs;
