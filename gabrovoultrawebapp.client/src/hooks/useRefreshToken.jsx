import axios from "../api/axios";
import useAuth from "./useAuth";
function useRefreshToken() {
  const { setAuth } = useAuth();

  const refresh = async () => {
    const response = await axios.get("/Auth/RefreshToken", {
      withCredentials: true,
    });
    setAuth((prev) => {
      return {
        ...prev,
        roles: response.data.roles,
        accessToken: response.data.jwtToken,
      };
    });
    return response.data.jwtToken;
  };
  return refresh;
}

export default useRefreshToken;
