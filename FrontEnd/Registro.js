// const btnRegistro=document.getElementById('btnRegistro');

// btnRegistro.addEventListener('click',(e)=>{
//     e.preventDefault();
//     const urlRegistro='https://localhost:7042/Registro/registro';

//     const name=document.getElementById('name').value;
//     const email=document.getElementById('email').value;
//     const password=document.getElementById('password').value;
    
//     const datos={
//         Name : name,
//         Email : email,
//         Password : password
//     };

//     const options={
//         method : 'POST',
//         headers : {
//             'Content-type' : 'application/json'
//         },
//         body:JSON.stringify(datos)
//     };

//     fetch(urlRegistro,options)
//     .then((response)=>{
//         if (!response.ok) {
//             throw new Error();
//         }
//         alert('Cuenta creada');
//         window.location.href='Index.html'
//     })
//     .catch(error=>{
//         alert(error);
//     })

// })