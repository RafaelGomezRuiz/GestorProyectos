
//agregar el evento click para que muestre el formulario
const liCrearTarea=document.getElementById('crear-tareas');
const divContenedor=document.getElementById('contenedor-inicio')
const btnCrearTarea= document.getElementById('btn-CrearTarea')

    // let formularios = document.getElementById('form-crear-tarea');
    
    //     formularios.style.display = 'none';
    

function CrearTarea()
{
    
    if(divContenedor.style.display ==='none')
    {
        divContenedor.style.display ='block' 
    }
    else{
        divContenedor.style.display ='none'
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
    const correoColaborador=document.getElementById('correo-colaborador').value;
    const urlCrearTarjeta='https://localhost:7042/CrearTarea/crearTarea';
    
    const datos={
        IdProyecto: idProyecto,
        Descripcion : descripcion,
        FechaVencimiento: fechaVencimiento,
        Email : correoColaborador
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
        alert("TareaCreada");
    })
    .catch((error)=>{
        alert(error);
    })
})