import { Col, Container, Image, Row } from "react-bootstrap";
function AboutUs() {
  return (
    <Container className="gap-5 p-5 m-auto" id="AboutUs">
      <Row>
        <Col xs={12} md={6} className="text-center m-auto">
          <blockquote className="blockquote">
            <p className="lead display-6">С дъх на ПРИКЛЮЧЕНИЕ</p>
            Аз съм величествена. Аз съм могъща. Аз съм красива. Иска се желание
            и упоритост, за да ме покориш, но си струва всяка крачка от пътя,
            който ще извървиш, за да го направиш. Ще взема дъха ти, ще накарам
            кръвта ти да бушува, но накрая...накрая ще се слеем в едно и ще
            разкрия пред теб нови хоризонти. Ще почувстваш отново хармонията, за
            която толкова си копнял. И когато там горе на върха видя усмивката
            ти ще знам, че съм успяла - че съм те направила малко по-добър,
            малко по-силен и че отново ще се върнеш при мен.
            <footer className="blockquote-footer m-3">
              Аз съм Габрово Ултра!
            </footer>
          </blockquote>
        </Col>

        <Col xs={12} md={6}>
          <Image src="public/Racho.jpg" fluid thumbnail="true" />
        </Col>
      </Row>
    </Container>
  );
}

export default AboutUs;
