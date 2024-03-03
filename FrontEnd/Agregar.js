const formAgregarColaborador= document.getElementById('form-agregar-colaborador');

const liAgregarColaborador=document.getElementById('agregar-colaboradores');
const btnColaborador=document.getElementById('btn-agregar-colaborador');



liAgregarColaborador.addEventListener('click',(e)=>
{
    DisplayStatus(formAgregarColaborador)
})

btnColaborador.addEventListener('click',(e)=>{
    e.preventDefault();
    DisplayStatus(formAgregarColaborador);
    const idTarea=document.getElementById('id-tarea').value;
    const emailColaborador=document.getElementById('email-colaborador').value;
    const urlAgregarColaborador='https://localhost:7042/AgregarColaboradores/agregarColaborador';
    
    const datos={
        Id : idTarea,
        Email : emailColaborador,
    }

    const options={
        method :'POST',
        headers:{ 
            'Content-Type' :'application/json'
        },
        body : JSON.stringify(datos)
    }
    
    fetch(urlAgregarColaborador,options)
    .then(Response =>{
        if(!Response.ok)
        {
            throw new Error("Valores invalidos en los campos");
        }
        alert('colaborador agregado')
    })
    .catch((error)=>alert(error))
    
})