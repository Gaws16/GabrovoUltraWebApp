import { useState, useEffect } from "react";
import useAxiosPrivate from "../src/hooks/useAxiosPrivate";
const Users = () => {
  const [users, setUsers] = useState([]);
  const axiosPrivate = useAxiosPrivate();

  useEffect(() => {
    let isMounted = true;
    const controller = new AbortController();

    const getUsers = async () => {
      try {
        const response = await axiosPrivate.get("/Users", {
          signal: controller.signal,
        });
        isMounted && setUsers(response.data);
      } catch (e) {
        console.log(e);
      }
    };
    getUsers();
    return () => {
      isMounted = false;
      controller.abort();
    };
  }, []);
  return (
    <article>
      <h1>Users</h1>
      {users?.length ? (
        <ul>
          {users.map((user, i) => (
            <li key={i}>{user?.name}</li>
          ))}
        </ul>
      ) : (
        <p>No users to display</p>
      )}
    </article>
  );
};

export default Users;
