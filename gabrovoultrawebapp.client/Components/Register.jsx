import { useState } from 'react';
function Register() {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    return (
        <form >
            <input onChange={(e) => setUsername(e.target.value)} type="text" placeholder="Username" value={username} />
            <input onChange={(e) => setPassword(e.target.value)} type="password" placeholder="Password" value={password} />
        </form>


  );
}

export default Register;