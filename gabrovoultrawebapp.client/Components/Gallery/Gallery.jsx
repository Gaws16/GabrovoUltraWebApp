import { useState, useEffect } from "react";
import { Container } from "react-bootstrap";
import Spinner from "react-bootstrap/Spinner";
import LazyImage from "./LazyImage";

export const Gallery = () => {
  const [active, setActive] = useState(0);
  const [heroSections, setHeroSections] = useState([]);
  const [loading, setLoading] = useState(true);
  useEffect(() => {
    async function fetchHeroSections() {
      try {
        setLoading(true);
        const response = await fetch(
          "https://localhost:7263/api/HeroSection/All"
        );
        setHeroSections(await response.json());
      } catch {
        alert("Error loading images!");
      } finally {
        setLoading(false);
      }
    }
    fetchHeroSections();
  }, []);
  const handleToggle = (index) => setActive(index);
  if (loading) {
    return (
      <Container className="possition-relative">
        <Spinner
          animation="border"
          className="position-absolute top-50 start-50"
        />
      </Container>
    );
  }
  return (
    <section className="image-accordion mt-5">
      {heroSections.map((item, index) => {
        const isActive = active === index ? "active" : "";
        return (
          <div
            key={item.imageUrl}
            className={`image-accordion-item ${isActive}`}
            onClick={() => handleToggle(index)}
          >
            <LazyImage src={item.imageUrl} />
            <div className="content">
              <div>
                <h2>{item.name}</h2>
                <p>{item.description}</p>
              </div>
            </div>
          </div>
        );
      })}
    </section>
  );
};
