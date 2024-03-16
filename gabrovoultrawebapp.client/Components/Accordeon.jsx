import { useState, useEffect } from "react";
//import "./styles.css";

export const ImageAccordion = () => {
  const [active, setActive] = useState(0);
  const [heroSections, setHeroSections] = useState([]);
  useEffect(() => {
    async function fetchHeroSections() {
      const response = await fetch(
        "https://localhost:7263/api/HeroSection/All"
      );
      setHeroSections(await response.json());
    }
    fetchHeroSections();
  }, []);
  const handleToggle = (index) => setActive(index);

  return (
    <section className="image-accordion">
      {heroSections.map((item, index) => {
        const isActive = active === index ? "active" : "";
        return (
          <div
            key={item.imageUrl}
            className={`image-accordion-item ${isActive}`}
            onClick={() => handleToggle(index)}
          >
            <img src={item.imageUrl} />
            <div className="content">
              <span className="material-symbols-outlined">G</span>
              <div>
                <h2>{item.Name}</h2>
                <p>{item.Description}</p>
              </div>
            </div>
          </div>
        );
      })}
    </section>
  );
};
