function inscricao(){
  alert("menos uma vaga");
}

var clicks = 5;

function onClick() {
  
  if(clicks==0){
    alert("sem vagas disponiveis"); 
  }else{
    alert("menos uma vaga");
    clicks -= 1;
    document.getElementById("clicks").innerHTML = clicks;
  }
  
  
};