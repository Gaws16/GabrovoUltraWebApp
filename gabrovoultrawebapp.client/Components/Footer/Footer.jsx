import { Image } from "react-bootstrap";
import styles from "./Footer.module.css";
export default function Footer() {
  return (
    <footer
      className={`page-footer font-small blue pt-4 ${styles.shadow} text-light `}
      style={{ backgroundColor: "rgb(33,37,41)" }}
    >
      <div className="footer-copyright text-center py-3 d-flex p-5 justify-content-between align-items-center">
        <div>
          <h5 className="">Габрово Ултра</h5>
          <Image width={55} height={55} src="/logo.svg" />
        </div>
        <div>
          <p>Дизайн и изработка М. Йорданов</p>
        </div>
        <div>
          <p>Духът на Стара планина</p>© {new Date().getFullYear()} Copyright:
        </div>
      </div>
    </footer>
  );
}
