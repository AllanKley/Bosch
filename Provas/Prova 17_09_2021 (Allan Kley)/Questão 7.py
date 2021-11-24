alfabeto=["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"]
cifrado=""
cod=input("digite a palavra a ser codificada: ")
cifra=int(input("Qual o numero para a codificação?\t"))
for letra in cod:
    for i in alfabeto:
        if letra == i:
            cifrado += alfabeto[(alfabeto.index(i)+cifra)]
            
print("Criptográfia: ",cifrado)