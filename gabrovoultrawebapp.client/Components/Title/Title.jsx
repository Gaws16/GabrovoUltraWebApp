import styles from "./Title.module.css";
function Title() {
  return (
    <main className={`${styles.shadow}`}>
      <div className={`${styles.wrapper} ${styles.invert} `}>
        <span data-text="Gabrovo"></span>

        <span data-text="Ultra"></span>
      </div>
    </main>
  );
}

export default Title;
