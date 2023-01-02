import React from 'react'

export default function Form() {
  return (
    <section>
        <div className='register'>
        < div className='col-1'>
            <h2>Dangerous Plants</h2>
            <span>Enter locations where you see dangerous plants</span>

            <form id='form' className='flex flex-col'>
                <input type="text" placeholder='Firstname'/>
                <input type="text" placeholder='Lastname'/>
                <input type="text" placeholder='Plant Type'/>
                <input type="text" placeholder='Date & Time'/>
                <input type="text" placeholder='Location'/>

                <button className='btn'> Add Location</button>
            </form>
        </div>
       
        
     </div>
      </section>
  )
}


