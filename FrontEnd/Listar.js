const urlListar='https://localhost:7042/Listar';
const liListarTareas= document.getElementById('listar-tareas');

const tablaTareas=document.getElementById('table-listar-tareas');
tablaTareas.style.display='none';

liListarTareas.addEventListener('click',(e)=>{

    DisplayStatus(tablaTareas);

    fetch(`${urlListar}/getListaTareas`)
    .then((Response)=> Response.json())
    .then((data)=>{
        MostrarTablaTareas(data);
    })
    .catch((error)=>{
        console.log(error);
    })
    
    const MostrarTablaTareas=(data)=>
    {
        
        let body=innerHTML='';
        for (let i = 0; i < data.length; i++) {
            let colaboradorAsignado='';
            for (let j = 0; j < data[i].colaboradorAsignado.length; j++) {
                colaboradorAsignado += data[i].colaboradorAsignado[j].email;
            }
            if (data[i].colaboradorAsignado.length<1)
            {
                colaboradorAsignado= '0';
            }
            body+=`<tr><td>${data[i].id}</td><td>${data[i].idProyecto}</td><td>${data[i].descripcion}</td><td>${data[i].estado}</td>
            <td>${data[i].fechaCreacion}</td><td>${data[i].fechaVencimiento}</td><td>${colaboradorAsignado}</td></tr>`
        }
        
        document.getElementById('body-listar-tareas').innerHTML=body;
    }
})

