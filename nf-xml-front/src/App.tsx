import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p><b>Ambiente:</b> {process.env.REACT_APP_AMBIENTE}</p>
        <p><b>Url importação:</b> {process.env.REACT_APP_API_IMPORTACAO_URL}</p>
      </header>
    </div>  
  );
}

export default App;
