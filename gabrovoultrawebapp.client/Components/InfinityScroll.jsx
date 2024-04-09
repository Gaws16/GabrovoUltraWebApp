import gsap from "gsap";
import { useGSAP } from "@gsap/react";
import { ScrollTrigger } from "gsap/all";
import { useEffect, useState } from "react";
import { axios } from "./../src/api/axios";
gsap.registerPlugin(ScrollTrigger);
const RUNNERS_URL = "/Runner?pageNumber=1&pageSize=1000";

export default function ScrollReveal() {
  const [data, setData] = useState([]);
  useEffect(() => {
    async function fetchRunners() {
      try {
        const response = await axios.get(RUNNERS_URL);
        console.log(response);
        setData(response.data);
      } catch (e) {
        console.log(e);
        alert("Error loading runners");
      }
    }
    fetchRunners();
    console.log(data);
  }, []);
  useGSAP(() => {
    ScrollTrigger.batch("section > div", {
      interval: 0.1,
      batchMax: 3,
      onEnter: (batch) =>
        gsap.to(batch, { autoAlpha: 1, stagger: 0.15, overwrite: true }),
      onLeave: (batch) => gsap.set(batch, { autoAlpha: 0, overwrite: true }),
      onEnterBack: (batch) =>
        gsap.to(batch, { autoAlpha: 1, stagger: 0.15, overwrite: true }),
      onLeaveBack: (batch) =>
        gsap.set(batch, { autoAlpha: 0, overwrite: true }),
    });
  }, []);

  return (
    <section className="scroll-reveal">
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
      <div></div>
    </section>
  );
}
