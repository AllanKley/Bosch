dic={}
menores={}
ide=[]
saida=False
while not saida:
    menu=int(input("Menu:\n(1)\tAdiconar um novo contato\n(2)\tSaida\n"))
    if menu==1:
        nome=input("digite seu nome:  ")
        idade=input("digite sua idade: ")
        dic[input("digite seu cpf: ")]=nome+"-"+idade
    elif menu==2:
        saida=True
    else:
        print("input invalido")
x=0

for i in dic.keys():
    ide=dic[i].split("-")
    if int(ide[1])<18:
        menores[i]=dic[i]

for h in menores.keys():
    dic.pop(h)
    
print("\nMaiores de idade:\n")
for k in dic.keys():
    print(f"{k}: {dic[k]}")
    
print("\nMenores de idade:\n")
for u in menores.keys():
    print(f"{u}: {menores[u]}")

