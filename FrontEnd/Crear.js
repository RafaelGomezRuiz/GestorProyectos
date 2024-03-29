
//agregar el evento click para que muestre el formulario
const liCrearTarea=document.getElementById('crear-tareas');
const divContenedor=document.getElementById('contenedor-inicio')
const btnCrearTarea= document.getElementById('btn-CrearTarea')

const formularioCrearTarea = document.getElementById('form-crear-tarea');

function DisplayStatus(tipoContenedor)
{
    
    if(tipoContenedor.style.display ==='none')
    {
        tipoContenedor.style.display ='block' 
    }
    else{
        tipoContenedor.style.display ='none'
    }
    
}
liCrearTarea.addEventListener('click',(e)=>{
    DisplayStatus(formularioCrearTarea);
});

//Funcion para crear Tareas


btnCrearTarea.addEventListener('click',(e)=>{
    e.preventDefault();
    e.stopPropagation();
    DisplayStatus(formularioCrearTarea);
 
        const idProyecto=document.getElementById('id-proyecto').value;
        const descripcion=document.getElementById('descripcion').value;
        const fechaVencimiento=document.getElementById('fecha-vencimiento').value;
        const tipoDb=document.getElementById('tipo-db').value;
        const urlCrearTarjeta='https://localhost:7042/Facade/crearTarea';
        
    const datos={
        IdProyecto: idProyecto,
        Descripcion : descripcion,
        FechaVencimiento: fechaVencimiento,
        TipoDb: tipoDb,
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
            return response.text().then((errorMessage) => {
                throw new Error(errorMessage);
            });
        }
        alert("Tarea Creada con exito");
    })
    .catch((error)=>alert('Error al crear la tarea: ' + error.message));
})