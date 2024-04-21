import { Routes, Route } from "react-router";
import Register from "../Components/Register/Register";
import AllRunners from "../Components/AllRunners";
import Login from "../Components/Login/Login";
import Layout from "../Components/Layout/Layout";
import Results from "../Components/Results";
import Profile from "../Components/Profile/Profile";
import AdminPanel from "../Components/Admin/AdminPanel";
import PageNotFound from "../Components/NotFoundPage/PageNotFound";
import RequireAuth from "../Components/RequireAuth";
import UnauthorizedPage from "../Components/UnauthorizedPage/UnauthorizedPage";
import LoginContext from "../Components/LoginWIthContext/LoginContext";
import Home from "../Components/OpeningPage/Layout";
export default function App() {
  return (
    <Routes>
      <Route path="/" element={<Layout />}>
        {/* public routes */}
        <Route path="/LoginCotext" element={<LoginContext />} />
        <Route path="/runners" element={<AllRunners />} />
        <Route path="/register" element={<Register />} />
        <Route path="/unauthorized" element={<UnauthorizedPage />} />
        <Route path="/login" element={<Login />} />
        <Route path="/" element={<Home />} />

        {/* private routes for normal users */}
        <Route element={<RequireAuth allowedRoles={["Reader"]} />}>
          <Route path="/Profile" element={<Profile />} />
          <Route path="/results" element={<Results />} />
        </Route>

        {/* private routes for admin users */}
        <Route element={<RequireAuth allowedRoles={["Writer"]} />}>
          <Route path="/Admin" element={<AdminPanel />} />
        </Route>

        {/* catch all*/}
        <Route path="*" element={<PageNotFound />} />
      </Route>
    </Routes>
  );
}
