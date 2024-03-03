const formAgregarColaborador= document.getElementById('form-agregar-colaborador');
formAgregarColaborador.style.display='none';


const liAgregarColaborador=document.getElementById('agregar-colaboradores');


liAgregarColaborador.addEventListener('click',(e)=>{
    e.preventDefault();
    DisplayStatus(formAgregarColaborador)

    const urlAgregarColaborador='https://localhost:7042/AgregarColaboradores/agregarColaborador';
    
    fetch()
    
})