import { useState, useEffect } from "react";
import "./styles.css";

export default function Parallax() {
  const [scrollPosition, setScrollPosition] = useState(0);

  const handleScroll = () => setScrollPosition(window.scrollY);

  useEffect(() => {
    window.addEventListener("scroll", handleScroll, { passive: true });

    return () => {
      window.removeEventListener("scroll", handleScroll);
    };
  }, []);

  return (
    <>
      <section
        style={{
          backgroundSize: `${(window.outerHeight - scrollPosition) / 2}%`,
        }}
        className="banner container"
      >
        <h2>Gabrovo Ultra</h2>
        <button>Get Started</button>
      </section>
    </>
  );
}
