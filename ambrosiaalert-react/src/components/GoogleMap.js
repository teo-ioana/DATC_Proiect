import React, { useEffect } from "react";

function GoogleMap(){
    useEffect(()=>{
        const ifameData=document.getElementById("iframeId")
        const lat=45.746;
        const lon=21.24;
        ifameData.src=`https://maps.google.com/maps?q=${lat},${lon}&hl=es;&output=embed`
    })
    return(
        <div>
            <iframe 
            id="iframeId" height="500px" width="100%"></iframe>
        </div>
    );
}
export default GoogleMap;