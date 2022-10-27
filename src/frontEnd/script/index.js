//const inputsCadastro = [...document.querySelectorAll("input")];
const botaoCadastro = document.getElementById("botaoLogin");
var cadastro1 = {};
//console.log(botaoCadastro)
botaoCadastro.onclick = ()=>{
    const nome = document.getElementById("nome");
    const email = document.getElementById("email");
    const senha = document.getElementById("senha");
    const contraSenha = document.getElementById("contraSenha");
    if (senha.value == contraSenha.value) {
        cadastro1.nome = nome.value;
        cadastro1.email = email.value;
        cadastro1.senha = senha.value;
        cadastro1.contraSenha = contraSenha.value;
    } else
        alert("Senha não confere");

    console.log(cadastro1);
}
 export var cadastro = cadastro1
 var usuario = await fetch("http://localhost:57331/Usuario", { mode: 'no-cors'})
 .catch(error =>{
    console.log(error)
 })
 .then(response =>{
    return response.json()
 })
 console.log(usuario);
 const init ={
    method: "POST",
    headers: {},
    body: JSON.stringify(cadastro1)
 }
 fetch("http://localhost:57331/Usuario",init, { mode: 'cors'})