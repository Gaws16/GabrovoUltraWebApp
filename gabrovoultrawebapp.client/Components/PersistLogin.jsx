import { Outlet } from "react-router-dom";
import { useState, useEffect } from "react";
import useRefreshToken from "../src/hooks/useRefreshToken";
import useAuth from "../src/hooks/useAuth";

const PersistLogin = () => {
  const [isLoading, sentIsLoading] = useState(true);
  const refresh = useRefreshToken();
  const { auth } = useAuth();

  useEffect(() => {
    const verifyRefreshToken = async () => {
      try {
        await refresh();
      } catch (error) {
        console.error(error);
      } finally {
        sentIsLoading(false);
      }
    };
    !auth?.accessToken ? verifyRefreshToken() : sentIsLoading(false);
  }, []);

  useEffect(() => {
    console.log("isLoading", isLoading);
    console.log(`aT: ${JSON.stringify(auth?.accessToken)}`);
  }, [isLoading]);
  return <>{isLoading ? <p>Loading...</p> : <Outlet />}</>;
};
export default PersistLogin;
