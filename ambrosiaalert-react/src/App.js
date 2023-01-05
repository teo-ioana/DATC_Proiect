import React from 'react';
import PostForm from './components/PostForm';
import GoogleMap from './components/GoogleMap';


function App(){
  return(
    <div className="App">
       <h1 style={{color:'white', backgroundColor:'green'}}>Ambrosia Alert</h1>
        <PostForm/>
        <GoogleMap/>
    </div>
  )
}
 export default App;