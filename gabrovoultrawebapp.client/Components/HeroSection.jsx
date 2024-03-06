import React, { useEffect, useState } from "react";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import LazyImage from "./LazyImage";

export default function HeroSection() {
  const [heroSections, setHeroSections] = useState([
    {
      Name: "Loading...",
      Description: "Loading...",
      ImageUrl: "loading...",
    },
  ]);
  useEffect(() => {
    async function fetchHeroSections() {
      const response = await fetch(
        "https://localhost:7263/api/HeroSection/All"
      );
      setHeroSections(await response.json());
    }
    fetchHeroSections();
  }, []);

  const currentSection = heroSections[0];

  return (
    <div id="carouselExample" className="carousel slide">
      <div className="carousel-inner">
        <div className="carousel-item active hero-section">
          <img src={currentSection.ImageUrl} className="hero-image" alt="..." />
        </div>
        {heroSections.map((section, index) => {
          return (
            index != 0 && (
              <div
                className="carousel-item hero-section"
                key={index}
                // style={{ width: "200px", height: "150px", overflow: "hidden" }}
              >
                <LazyImage
                  src={section.ImageUrl}
                  alt={section.Name}
                  className="hero-image "
                />
              </div>
            )
          );
        })}
      </div>
      <button
        className="carousel-control-prev"
        type="button"
        data-bs-target="#carouselExample"
        data-bs-slide="prev"
      >
        <span className="carousel-control-prev-icon" aria-hidden="true"></span>
        <span className="visually-hidden">Previous</span>
      </button>
      <button
        className="carousel-control-next"
        type="button"
        data-bs-target="#carouselExample"
        data-bs-slide="next"
      >
        <span className="carousel-control-next-icon" aria-hidden="true"></span>
        <span className="visually-hidden">Next</span>
      </button>
    </div>
  );
}
