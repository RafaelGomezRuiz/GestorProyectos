const btnLogin=document.getElementById('btn');

btnLogin.addEventListener('click',(e)=>{
    e.preventDefault();
    const urlLogin='https://localhost:7042/Login/login'
    
    const email=document.getElementById('email').value;
    const password=document.getElementById('password').value;

    const datos={
        email : email,
        password : password
    }

    const options=
    {
        method:"POST",
        headers:{
            'Content-Type' : 'application/json'
        },
        body : JSON.stringify(datos),  
            // Ignorar errores de certificado
        //agent: new https.Agent({ rejectUnauthorized: false })
    }

    fetch(urlLogin,options)
    .then((response)=>{
        if(!response.ok)
        {
            throw new Error("Credenciales invalidas");
        }
        //window.location.href="Inicio.html";
        return response.json();
    })
    .catch(error=>{
        console.log("object");   
        alert(error);
    })

})
