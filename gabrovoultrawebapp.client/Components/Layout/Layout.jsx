import { Outlet } from "react-router-dom";
import CustomNav from "../CustomNav/CustomNav";
import Footer from "../Footer/Footer";
import { useEffect, useState } from "react";
function Layout() {
  const [display, setDisplay] = useState(false);

  useEffect(() => {
    window.addEventListener("scroll", () => {
      if (window.scrollY > 400) {
        setDisplay(true);
      } else {
        setDisplay(false);
      }
    });
  }, []);
  return (
    <main className="vh-100">
      <CustomNav display={display} />
      <Outlet />
      <Footer />
    </main>
  );
}

export default Layout;
