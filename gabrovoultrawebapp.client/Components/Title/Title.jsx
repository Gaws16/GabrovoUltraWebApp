import styles from "./Title.module.css";
import { Card, Container, Button, Row } from "react-bootstrap";
function Title() {
  return (
    <>
      <main className={`${styles.shadow}`}>
        <div className={`${styles.wrapper} ${styles.invert} `}>
          <span data-text="Gabrovo"></span>

          <span data-text="Ultra"></span>
        </div>
      </main>

      <Button
        href="#AboutUs"
        size="lg"
        variant="outline-light"
        className={styles.shadow}
      >
        Wellcome!
      </Button>
    </>
  );
}

export default Title;
