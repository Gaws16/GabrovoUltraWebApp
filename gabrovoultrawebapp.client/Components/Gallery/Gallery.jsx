import { useState, useEffect } from "react";
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
          "https://app-gabrovoultra-gwc-dev-001.azurewebsites.net/api/HeroSection/All"
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
    return <h1>Loading...</h1>;
  }
  return heroSections.length === 0 ? (
    <h1>No images</h1>
  ) : (
    <section className="image-accordion mt-5 mb-5">
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
