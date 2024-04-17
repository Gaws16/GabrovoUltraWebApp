import { Gallery } from "../Components/Gallery/Gallery";
import { BrowserRouter } from "react-router-dom";
import { Routes, Route } from "react-router";
import Register from "../Components/Register/Register";
import AllRunners from "../Components/AllRunners";
import { useEffect, useState } from "react";
import CustomNav from "../Components/CustomNav/CustomNav";
import Login from "../Components/Login/Login";
import Layout from "../Components/OpeningPage/Layout";
import AboutUs from "../Components/AboutUs";
import DistancesMain from "../Components/Distances/Main/DistanceMain";
import Results from "../Components/Results";
import Profile from "../Components/Profile/Profile";
import AdminPanel from "../Components/Admin/AdminPanel";
import Footer from "../Components/Footer/Footer";
import PageNotFound from "../Components/NotFoundPage/PageNotFound";
import UnauthorizedPage from "../Components/UnauthorizedPage/UnauthorizedPage";
export default function App() {
  const [display, setDisplay] = useState(false);
  const [loggedIn, setLoggedIn] = useState(false);

  useEffect(() => {
    window.addEventListener("scroll", () => {
      if (window.scrollY > 400) {
        setDisplay(true);
      } else {
        setDisplay(false);
      }
      if (localStorage.getItem("token")) {
        setLoggedIn(true);
      }
    });
  }, []);
  return (
    <BrowserRouter>
      <CustomNav
        handleDisplay={setDisplay}
        loggedIn={loggedIn}
        display={display}
      />
      <Routes>
        <Route index element={<Layout />} />
        <Route path="*" element={<PageNotFound />} />
        <Route path="/layout" element={<Layout />} />
        {localStorage.getItem("role") === "Writer" ? (
          <Route path="/Admin" element={<AdminPanel />} />
        ) : (
          <Route path="/Admin" element={<UnauthorizedPage />} />
        )}
        <Route path="/Profile" element={<Profile />} />
        <Route path="/gallery" element={<Gallery />} />
        <Route path="/home" element={<AboutUs />} />
        <Route path="/results" element={<Results />} />
        <Route path="/distances" element={<DistancesMain />} />
        <Route path="/runners" element={<AllRunners />} />
        <Route path="/register" element={<Register />} />
        {localStorage.getItem("token") === undefined ? (
          <Route path="/login" element={<Login />} />
        ) : (
          <Route path="/login" element={<Layout />} />
        )}
      </Routes>
      <Footer />
    </BrowserRouter>
  );
}
