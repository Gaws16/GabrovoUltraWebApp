import React, { useEffect, useState } from "react";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import LazyImage from "./LazyImage";
import NavBar from "./NavBar";

export default function HeroSection() {
  const [heroSections, setHeroSections] = useState([
    {
      Name: "Loading...",
      Description: "Loading...",
      ImageUrl: "loading...",
    },
  ]);
  const [prevScrollPos, setPrevScrollPos] = useState(0);
  const [visible, setVisible] = useState(true);

  useEffect(() => {
    async function fetchHeroSections() {
      const response = await fetch(
        "https://localhost:7263/api/HeroSection/All"
      );
      setHeroSections(await response.json());
    }
    fetchHeroSections();

    const handleScroll = () => {
      const currentScrollPos = window.scrollY;

      setVisible(
        (prevScrollPos > currentScrollPos &&
          prevScrollPos - currentScrollPos > 70) ||
          currentScrollPos < 10
      );

      setPrevScrollPos(currentScrollPos);
    };

    window.addEventListener("scroll", handleScroll);

    return () => window.removeEventListener("scroll", handleScroll);
  }, [prevScrollPos, visible]);

  const currentSection = heroSections[0];

  return (
    <div>
      {visible && <NavBar />}
      <div id="carouselExample" className="carousel slide" data-ride="carousel">
        <div className="carousel-inner">
          <div className="carousel-item active hero-section">
            <img src={currentSection.ImageUrl} className="w-100" alt="..." />
          </div>
          {heroSections.map((section, index) => {
            return (
              index !== 0 && (
                <div
                  className="carousel-item hero-section"
                  style={{ objectFit: "center", height: "50vh" }}
                  key={index}
                >
                  <LazyImage
                    src={section.ImageUrl}
                    alt={section.Name}
                    className="img-fluid w-100"
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
          <span
            className="carousel-control-prev-icon"
            aria-hidden="true"
          ></span>
          <span className="visually-hidden">Previous</span>
        </button>
        <button
          className="carousel-control-next"
          type="button"
          data-bs-target="#carouselExample"
          data-bs-slide="next"
        >
          <span
            className="carousel-control-next-icon"
            aria-hidden="true"
          ></span>
          <span className="visually-hidden">Next</span>
        </button>
      </div>
    </div>
  );
}
