import './App.css';
import { useState } from 'react';

const App = () => {
  const [ username, setUsername ] = useState ('')
  const [ password, setPassword ] = useState ('')

  const connect = () => {
    fetch( 
      `http://localhost:5000/login?user=${username}&password=${password}`,
      {mode:'cors', method: 'GET'} 
    ).then( result => {
      console.log( result )
      return result.json()
    }).then( result => {
      console.log ( result )
    }).catch(err => {
      console.log (err)
    })
  }

  const enviarForm = (event) => {
    event.preventDefault();
    
  }

  function alterarUsername (event){
    // An input element and a HTML is taking propriedades.
    setUsername(event.target.value);
  }

  return (
    <div className="App">
      <form onSubmit = {enviarForm}>
        <input type="username" value ={ username } onChange= {alterarUsername} placeholder = "Username"/>
        <br />
        <input type="password" value ={ password } onChange= {(event) => setPassword (event.target.value)} placeholder = "Password"/>
        <br />
        <button onClick = { connect }> 
          Entrar
        </button>
 
      </form>
    </div>
  );
}

export default App;
