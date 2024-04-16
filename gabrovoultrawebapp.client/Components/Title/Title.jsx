import styles from "./Title.module.css";
import { Button } from "react-bootstrap";
function Title() {
  return (
    <>
      <main className={`${styles.shadow}`}>
        <div className={`${styles.wrapper} ${styles.invert} `}>
          <span className="pb-5" data-text="Габрово"></span>

          <span className="pt-5" data-text="Ултра"></span>
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
