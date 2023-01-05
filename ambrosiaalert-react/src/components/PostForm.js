import React, {useState} from 'react';
import Axios from 'axios'

function PostForm(){   
    const url ="https://localhost:7100/AmbrosiaAlert/PostPlanta"
    const[data, setData] = useState ({
        PartitionKey: "",
        RowKey: "",
        Latitudine: "",
        Longitudine: "",
        TipPlantaAlergena: ""
    })

    function submit(e){
        e.preventDefault();
        Axios.post(url, {
            PartitionKey: data.PartitionKey,
            RowKey: data.RowKey,
            Latitudine: data.Latitudine,
            Longitudine: data.Longitudine,
            TipPlantaAlergena: data.TipPlantaAlergena
        })
        .then(res=>{
            console.log(res.data)
        })

    }
    function handle(e){
        const newdata = {...data}
        newdata[e.target.id] = e.target.value
        setData(newdata)
        console.log(newdata)

    }
    return(
        <div>
            <form onSubmit={(e)=>submit(e)}>
                <input onChange={(e)=>handle(e)} id="PartitionKey" value={data.PartitionKey} placeholder="CNP" type="text"></input>
                <input onChange={(e)=>handle(e)} id="RowKey" value={data.RowKey} placeholder="Data & ora" type="text"></input>
                <input onChange={(e)=>handle(e)} id="Latitudine" value={data.Latitudine} placeholder="Latitudine" type="text"></input>
                <input onChange={(e)=>handle(e)} id="Longitudine" value={data.Longitudine} placeholder="Longitudine" type="text"></input>
                <input onChange={(e)=>handle(e)} id="TipPlantaAlergena" value={data.TipPlantaAlergena} placeholder="Tip Planta Alergena" type="text"></input>
                <button style={{color:'white',backgroundColor:'green'}}>Adauga</button>
            </form>
        </div>
    );

}

export default PostForm;
