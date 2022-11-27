
//const inputsCadastro = [...document.querySelectorAll("input")];
var dados = {
    nome: "",
    email: "",
    senha: "",
    contraSenha:""

}
function teste(){
    dados.nome = document.getElementById("nome").value;
    dados.email = document.getElementById("email").value;
    dados.senha = document.getElementById("senha").value;
    dados.contraSenha = document.getElementById("contraSenha").value;
    if (dados.senha == dados.contraSenha) {
        console.log(nome.valor)
        window.localStorage.setItem(dados.nome, JSON.stringify(dados) )
        alert(window.localStorage.getItem(dados.nome));
       window.location.href=`index_Josy.html?nome=${dados.nome}`
    //    cadastro1.contraSenha = contraSenha.value;
    } else
        alert("Senha não confere");
    
}
/*
const botaoCadastro = document.getElementById("botaoLogin");
var cadastro1 = {};
var data1 ={
    "nome": "Edglei1",
    "senha": "876543210"
};
var data = {
    nome: "Edglei1",
    email: "d@test.com",
    senha: "12"
};

//console.log(botaoCadastro)
botaoCadastro.onclick = async ()=>{
    const nome = document.getElementById("nome");
    const email = document.getElementById("email");
    const senha = document.getElementById("senha");
    const contraSenha = document.getElementById("contraSenha");
    if (senha.value == contraSenha.value) {
        cadastro1.nome = nome.value;
        cadastro1.email = email.value;
        cadastro1.senha = senha.value;
    //    cadastro1.contraSenha = contraSenha.value;
    } else
        alert("Senha não confere");
 //   const envia = JSON.stringify(data);
    const envia =JSON.stringify(data1);

    const init ={
        method: "POST",
        headers: {"Content-Type": 'applicatio/json'},
        body: envia
     }
    const escreve = await fetch('https://localhost:5001/api/Users',init).then((response) => response.json())
        .catch(function(error) {
        console.log('Fetch Error:', error)
    });

}

 
const response = await fetch("https://localhost:5001/api/Users/").then((resp) => resp.json())
//axios.get('https://localhost:44380/api/Users/Id?id=2').then(response => console.log(`O valor é: ${JSON.stringify(response.data)}`)).catch(err => console.log(err));

console.log(response);*/
