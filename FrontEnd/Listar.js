const urlListar='https://localhost:7042/Facade';
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
        
        let body='';
        for (let i = 0; i < data.length; i++) {
            body+=`<tr><td>${data[i].id}</td><td>${data[i].idProyecto}</td><td>${data[i].descripcion}</td><td>${data[i].estado}</td>
            <td>${data[i].fechaCreacion}</td><td>${data[i].fechaVencimiento}</td><td>${data[i].colaboradorAsignado}</td></tr>`
        }
        
        document.getElementById('body-listar-tareas').innerHTML=body;
    }
})

//Listar Proyectos
const liListarProyectos=document.getElementById('listar-proyectos');
const tablaProyectos=document.getElementById('table-listar-proyectos');

liListarProyectos.addEventListener('click',(e)=>{
    DisplayStatus(tablaProyectos);

    fetch(`${urlListar}/getListaProyectos`)
    .then((response)=>response.json())
    .then(datos=>{
        MostrarTablaProyectos(datos);
    })
    .catch((error)=>alert(error))

    let template='';
    function MostrarTablaProyectos(datos)
    {
        let colaboradores='';
        for (let i = 0; i < datos.length; i++) {
            
            template+=`<tr><td>${datos[i].id}</><td>${datos[i].nombre}</td><td>${datos[i].descripcion}</td>
            <td>${datos[i].estado}</td><td>${datos[i].fechaCreacion}</td><td>${datos[i].fechaVencimiento}</td>
            </tr>` ;  
        }
        document.getElementById('body-listar-proyectos').innerHTML=template;
    }
})



