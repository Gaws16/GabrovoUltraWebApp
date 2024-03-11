import { useEffect, useRef } from "react";

const LazyImage = ({ src, alt, className }) => {
  const imageRef = useRef(null);

  useEffect(() => {
    const observer = new IntersectionObserver((entries) => {
      entries.forEach((entry) => {
        if (entry.isIntersecting) {
          imageRef.current.src = src;
          observer.unobserve(imageRef.current);
        }
      });
    });

    observer.observe(imageRef.current);

    return () => {
      observer.disconnect();
    };
  }, [src]);

  return (
    <img
      ref={imageRef}
      alt={alt}
      className={className}
      //style={{ width: "100%", height: "auto" }}
    />
  );
};

export default LazyImage;
