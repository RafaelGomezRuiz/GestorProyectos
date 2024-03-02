
//agregar el evento click para que muestre el formulario
const liCrearTarea=document.getElementById('crear-tareas');
const divContenedor=document.getElementById('contenedor-inicio')
const btnCrearTarea= document.getElementById('btn-CrearTarea')

const formularioCrearTarea = document.getElementById('form-crear-tarea');
formularioCrearTarea.style.display = 'none';
    

function CrearTarea()
{
    
    if(formularioCrearTarea.style.display ==='none')
    {
        formularioCrearTarea.style.display ='block' 
    }
    else{
        formularioCrearTarea.style.display ='none'
    }
    
}
liCrearTarea.addEventListener('click',CrearTarea);

//Funcion para crear Tareas


btnCrearTarea.addEventListener('click',(e)=>{
    e.preventDefault();
    e.stopPropagation();
    const idProyecto=document.getElementById('id-proyecto').value;
    const descripcion=document.getElementById('descripcion').value;
    const fechaVencimiento=document.getElementById('fecha-vencimiento').value;
    const urlCrearTarjeta='https://localhost:7042/CrearTarea/crearTarea';
    
    const datos={
        IdProyecto: idProyecto,
        Descripcion : descripcion,
        FechaVencimiento: fechaVencimiento,
    }
    const options={
        method:"POST",
        headers:{
            'Content-Type':'application/json'
        },
        body : JSON.stringify(datos)
    }
    fetch(urlCrearTarjeta,options)
    .then((response)=>{
        if (!response.ok) {
            throw new Error();
        }
        alert("Tarea Creada");
    })
    .catch((error)=>{
        alert(error);
    })
})